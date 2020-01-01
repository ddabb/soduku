using System.ComponentModel;

namespace SudokuUI
{
    public enum RelationShip
    {

        [Description("不确定")] NotConfirm,
        [Description("推导出")] LeadTo,
        [Description("同真")] SameTrue,
    }
}