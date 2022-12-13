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
  
  public FillToRectangleImpl(): base() {}
  
  public FillToRectangleImpl(DocumentFormat.OpenXml.Office2010.Word.FillToRectangle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Left
  {
    get => (System.Int32?)OpenXmlElement?.Left?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Left = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Top
  {
    get => (System.Int32?)OpenXmlElement?.Top?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Top = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Right
  {
    get => (System.Int32?)OpenXmlElement?.Right?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Right = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Bottom
  {
    get => (System.Int32?)OpenXmlElement?.Bottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bottom = (System.Int32?)value;
    }
  }
  
}
