namespace AdapterPattern.CSSeries;

internal sealed class CS02 : ICSSeries
{
  private CS02() { }
  public static CS02 Instance { get; } = new CS02();

  public int GetMeasure()
  {
    // いろいろなロジック及び処理後
    // ...

    return 2000;
  }
}
