using System.ComponentModel;

namespace SudokuBase
{
    /// <summary>
    /// 方法方向
    /// </summary>
    public enum MethodDiction
    {
        [Description("行")] Row,
        [Description("列")] Column,
        [Description("宫")] Block
    }
}