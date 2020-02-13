using System;

namespace NetworkLocationEditor.Util
{
    class BinDateConverter
    {

        /// <summary>
        /// 将注册表中使用二进制格式存放的日期，转换为DateTime对象
        /// 二进制日期共16字节，每两字节为一组，每组高低位互换后，即为真实值
        /// 格式：年 月 星期 日 时 分 秒 毫秒
        /// </summary>
        /// <param name="date">二进制格式日期</param>
        /// <returns>日期对象</returns>
        public static DateTime Parse(byte[] date)
        {
            if (date.Length != 16)
            {
                throw new FormatException("二进制日期格式错误！");
            }
            string text = String.Format("{0}-{1}-{2} {3}:{4}:{5}", 0x100 * date[1] + date[0], date[2], date[6], date[8], date[10], date[12]);
            DateTime result = DateTime.Parse(text);
            return result;
        }

    }
}
