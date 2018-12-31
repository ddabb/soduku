using System;
using System.Text;

namespace SodukuBase
{
    public class DanceLink

    {

        const int RR = 729;

        const int CC = 324;

        const int INF = 1000000000;

        int[] mem = new int[RR + 9];

        int[] ans = new int[RR + 9];

        char[] ch = new char[RR + 9];

        /// <summary>
        /// 每列结点个数
        /// </summary>
        int[] cnt = new int[CC + 9];

        /// <summary>
        /// 结点
        /// </summary>
        class node

        {
            /// <summary>
            /// 所在行
            /// </summary>
            public int row;

            /// <summary>
            /// 所在列
            /// </summary>
            public int column;

            /// <summary>
            /// 上边结点
            /// </summary>
            public node up;
            /// <summary>
            /// 下面结点
            /// </summary>
            public node down;
            /// <summary>
            /// 左边结点
            /// </summary>
            public node left;
            /// <summary>
            /// 右边结点
            /// </summary>
            public node right;

        };

        node head;

        node[] all = new node[RR * CC + 99];

        node[] row = new node[RR];

        node[] col = new node[CC];

        int all_t;

        void link(int r, int c)

        {

            cnt[c]++;

            node t = all[all_t];

            if (t == null)

            {

                t = new node();

                all[all_t] = t;

            }

            all_t++;

            t.row = r;

            t.column = c;

            t.left = row[r];

            t.right = row[r].right;

            t.left.right = t;

            t.right.left = t;

            t.up = col[c];

            t.down = col[c].down;

            t.up.down = t;

            t.down.up = t;

        }

        void remove(int c)

        {

            node t, tt;

            col[c].right.left = col[c].left;

            col[c].left.right = col[c].right;

            for (t = col[c].down; !Object.ReferenceEquals(t, col[c]); t = t.down)

            {

                for (tt = t.right; !Object.ReferenceEquals(tt, t); tt = tt.right)

                {

                    cnt[tt.column]--;

                    tt.up.down = tt.down;

                    tt.down.up = tt.up;

                }

                t.left.right = t.right;

                t.right.left = t.left;

            }

        }

        void resume(int c)

        {

            node t, tt;

            for (t = col[c].down; !Object.ReferenceEquals(t, col[c]); t = t.down)

            {

                t.right.left = t;

                t.left.right = t;

                for (tt = t.left; !Object.ReferenceEquals(tt, t); tt = tt.left)

                {

                    cnt[tt.column]++;

                    tt.down.up = tt;

                    tt.up.down = tt;

                }

            }

            col[c].left.right = col[c];

            col[c].right.left = col[c];

        }

        int solve(int k)

        {

            if (Object.ReferenceEquals(head.right, head))

                return 1;

            node t, tt;

            int min = INF, tc = 0;

            for (t = head.right; !Object.ReferenceEquals(t, head); t = t.right)

            {

                if (cnt[t.column] < min)

                {

                    min = cnt[t.column];

                    tc = t.column;

                    if (min <= 1) break;

                }

            }

            remove(tc);

            int scnt = 0;

            for (t = col[tc].down; !Object.ReferenceEquals(t, col[tc]); t = t.down)

            {

                mem[k] = t.row;

                t.left.right = t;

                for (tt = t.right; !Object.ReferenceEquals(tt, t); tt = tt.right)

                {

                    remove(tt.column);

                }

                t.left.right = t.right;

                scnt += solve(k + 1);

                if (!chk_unique && scnt == 1)

                    return scnt;

                if (scnt > 1)

                    return scnt;

                //继续找下个可能

                t.right.left = t;

                for (tt = t.left; !Object.ReferenceEquals(tt, t); tt = tt.left)

                {

                    resume(tt.column);

                }

                t.right.left = t.left;

            }

            resume(tc);

            return scnt;

        }

        private bool chk_unique = false;

        public int scount = 0;

        public int solution_count(String str)

        {

            chk_unique = true;

            run(str);

            return scount;

        }
        /// <summary>
        /// 调用示例: new DanceLink().do_solve("693241578587639412421578396875963241214857639936124857142785963369412785758390000");
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public String do_solve(String str)

        {

            chk_unique = true;

            String ret = run(str);

            if (scount != 1)

                return "";

            return ret;

        }

        public String run(String str)

        {

            mem = new int[RR + 9];

            ans = new int[RR + 9];

            ch = new char[RR + 9];

            String s = str.Replace("\r", "");

            s = s.Replace("\n", "");

            ch = s.ToCharArray();

            cnt = new int[CC + 9];

            head = new node();

            all = new node[RR * CC + 99];

            row = new node[RR];

            col = new node[CC];

            {

                int i;

                all_t = 1;

                cnt = new int[CC + 9];

                head.left = head;

                head.right = head;

                head.up = head;

                head.down = head;

                head.row = RR;

                head.column = CC;

                for (i = 0; i < CC; i++)

                {

                    col[i] = new node();

                    col[i].column = i;

                    col[i].row = RR;

                    col[i].up = col[i];

                    col[i].down = col[i];

                    col[i].left = head;

                    col[i].right = head.right;

                    col[i].left.right = col[i];

                    col[i].right.left = col[i];

                }

                for (i = 0; i < RR; i++)

                {

                    row[i] = new node();

                    row[i].row = i;

                    row[i].column = CC;

                    row[i].left = row[i];

                    row[i].right = row[i];

                    row[i].up = head;

                    row[i].down = head.down;

                    row[i].up.down = row[i];

                    row[i].down.up = row[i];

                }

                for (i = 0; i < RR; i++)

                {

                    int r = i / 9 / 9 % 9;

                    int c = i / 9 % 9;

                    int val = i % 9 + 1;

                    if (ch[r * 9 + c] == '.' || ch[r * 9 + c] == '0' || ch[r * 9 + c] == val + '0')

                    {

                        link(i, r * 9 + val - 1);

                        link(i, 81 + c * 9 + val - 1);

                        int tr = r / 3;

                        int tc = c / 3;

                        link(i, 162 + (tr * 3 + tc) * 9 + val - 1);

                        link(i, 243 + r * 9 + c);

                    }

                }

                for (i = 0; i < RR; i++)

                {

                    row[i].left.right = row[i].right;

                    row[i].right.left = row[i].left;

                }

                scount = solve(1);

                for (i = 1; i <= 81; i++)

                {

                    int t = mem[i] / 9 % 81;

                    int val = mem[i] % 9 + 1;

                    ans[t] = val;

                }

                StringBuilder sb = new StringBuilder();

                for (i = 0; i < 81; i++)

                {

                    sb.Append(ans[i]);

                }

                return sb.ToString();

            }

        }



    }
}
