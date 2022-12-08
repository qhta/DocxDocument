namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FillToRectangle Class.
/// </summary>
public class FillToRectangleImpl: ModelElementImpl, FillToRectangle
{
  public DocumentFormat.OpenXml.Office2010.Word.FillToRectangle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.FillToRectangle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Left
  {
    get;
    set;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Bottom
  {
    get;
    set;
  }
  
}
