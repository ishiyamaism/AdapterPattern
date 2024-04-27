using VBClassLibrary;

namespace AdapterPattern.CSSeries;

/// <summary>
/// コンポジションによるAdapterパターン
/// </summary>
internal class VB01Adapter : ICSSeries
{
  private VB01Adapter() { }
  public static VB01Adapter Instance { get; } = new VB01Adapter();


  private VB01 _vb01 = new VB01();
  public int GetMeasure()
  {
    return _vb01.GetValue();
  }
}
