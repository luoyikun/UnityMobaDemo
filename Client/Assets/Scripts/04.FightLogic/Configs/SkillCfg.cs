
/// 技能配置
public class SkillCfg
{
    public int skillId;
    /// 技能图标
    public string iconName;
    /// 施法动画
    public string aniName;
    
    /// TODO 音效
    
    /// CD时间 ms
    public int cdTime;
    /// 施法时间(前摇) ms
    public int spellTime;
    /// 技能全长时间(前摇+后摇) ms
    /// 后摇动作均可被移动中断，但技能总时间不能变短
    public int skillTime;
    
    /// 基础伤害数值
    public int damage;
    /// 附加Buff
    public int[] buffIdArr;
    
    /// 是否为普通攻击
    public bool isNormalAttack;
    /// 释放方式
    public ReleaseModeEnum releaseMode;
    /// 目标选择配置,null为非锁定弹道技能
    public TargetCfg targetCfg;

}

public enum ReleaseModeEnum
{
    None,
    Click,// 点击直接释放
    Position,// 根据位置释放
    Direction,// 根据方向释放
}