/***
 * 资源管理类
 */
public class ResManager {
	static ResManager _manager = new ResManager ();
	public static ResManager Inst() {
		return _manager;
	}
		
	private ResWater _water = new ResWater();
	private ResPower _power = new ResPower();
	private ResSprite _sprite = new ResSprite();

	public void addWater(int count) {
		_water.add(count);
	}

	public void addPower(int count) {
		_power.add(count);
	}

	public void addSprite(int count) {
		_sprite.add(count);
	}
}


