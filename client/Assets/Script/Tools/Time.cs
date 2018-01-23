/***
 * 时间类
 */
using System;

public class Time {

	// 获得时间戳
	public static long GetTimeStamp() {
		TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);  
		return Convert.ToInt64(ts.TotalSeconds);  
	}
}



