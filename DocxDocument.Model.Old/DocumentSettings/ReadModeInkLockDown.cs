namespace DocxDocument.Model;

public class ReadModeInkLockDown: DocxBasedElement<WD.ReadModeInkLockDown>, IReadModeInkLockDown
{
  public ReadModeInkLockDown() : base(new WD.ReadModeInkLockDown())
  {
  }

  public ReadModeInkLockDown(WD.ReadModeInkLockDown element) : base(element)
  {
  }

  /// <summary> 
  /// Font Size Scaling.
  ///</summary>
  public Percentage? FontSize
  {
    get => DocxRead.ReadPercentage(DocxElement.FontSize);
    set => DocxElement.FontSize = (value!=null) ? ((int)value).ToString() : null;
  }

  /// <summary> 
  /// Use Actual Pages, Not Virtual Pages.
  ///</summary> 
  public bool? UseActualPages
  {
    get => DocxRead.ReadBoolean(DocxElement.UseActualPages);
    set => DocxElement.UseActualPages = (value!=null) ? value : null;
  }

  /// <summary> 
  /// Virtual Page Width.
  ///</summary> 
  public Pixels? Width
  {
    get => DocxRead.ReadInteger(DocxElement.Width);
    set => DocxElement.Width = (value != null) ? (uint)value : null;
  }

  /// <summary> 
  /// Virtual Page Height.
  ///</summary> 
  public Pixels? Height
  {
    get => DocxRead.ReadInteger(DocxElement.Height);
    set => DocxElement.Height = (value != null) ? (uint)value : null;
  }


}