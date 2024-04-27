using VBClassLibrary;

namespace AdapterPattern.CSSeries;

/// <summary>
/// 継承によるAdapterパターン
/// </summary>
internal class VB01Adapter2 : VB01, ICSSeries
{
  private VB01Adapter2() { }
  public static VB01Adapter2 Instance { get; } = new VB01Adapter2();

  public int GetMeasure()
  {
    return base.GetValue();
  }
}
