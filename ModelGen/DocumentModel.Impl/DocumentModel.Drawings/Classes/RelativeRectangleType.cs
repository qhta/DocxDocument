namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RelativeRectangleType Class.
/// </summary>
public partial class RelativeRectangleTypeImpl: ModelElementImpl, RelativeRectangleType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.RelativeRectangleType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.RelativeRectangleType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RelativeRectangleTypeImpl(): base() {}
  
  public RelativeRectangleTypeImpl(DocumentFormat.OpenXml.Drawing.RelativeRectangleType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Left Offset
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
  /// Top Offset
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
  /// Right Offset
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
  /// Bottom Offset
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
