namespace AdapterPattern.CSSeries;

internal sealed class CS01 : ICSSeries
{
  private CS01() { }
  public static CS01 Instance { get; } = new CS01();
  public int GetMeasure()
  {
    // いろいろなロジック及び処理後
    // ...

    return 1000;
  }
}
