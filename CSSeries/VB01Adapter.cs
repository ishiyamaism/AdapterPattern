using VBClassLibrary;

namespace AdapterPattern.CSSeries;

/// <summary>
/// コンポジションによるAdapterパターン
/// </summary>
internal class VB01Adapter : ICSSeries
{
  private VB01Adapter() { }
  public static VB01Adapter Instance { get; } = new VB01Adapter();

  // このようにコンポジションする
  private VB01 _vb01 = new VB01();

  /// <summary>
  /// 現Interfaceのメソッドでラップする形
  /// </summary>
  /// <returns></returns>
  public int GetMeasure()
  {
    return _vb01.GetValue();
  }
}
