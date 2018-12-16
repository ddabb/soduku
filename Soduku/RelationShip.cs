using System.ComponentModel;

namespace SodukuUI
{
    public enum RelationShip
    {

        [Description("不确定")] NotConfirm,
        [Description("推导出")] LeadTo,
        [Description("同真")] SameTrue,
    }
}