/***
 * 对象-基础类
 */
public class Object {
	static uint _sid = 0;

	uint _id = 0;
	public Object() {
		_id = _sid++;
	}
}
