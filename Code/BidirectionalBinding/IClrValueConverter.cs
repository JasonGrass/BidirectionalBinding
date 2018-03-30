using System;
using System.Collections.Generic;
using System.Text;

namespace BidirectionalBinding
{

    public interface IClrValueConverter
    {
        object Convert(object value, Type targetType, object parameter, out bool success);
        object ConvertBack(object value, Type targetType, object parameterm, out bool success);
    }

    /// <summary>
    /// 绑定初始化时的值传递方向
    /// </summary>
    public enum BindingInitMode
    {
        /// <summary>
        /// 使用被绑定对象的值设置当前对象的值（默认）
        /// </summary>
        SourceToTarget = 0,

        /// <summary>
        /// 使用当前对象的值设置被绑定对象的值
        /// </summary>
        TargetToSource = 1,
    }

}
