namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public partial class MatrixColumnPropertiesImpl: ModelElementImpl, MatrixColumnProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.MatrixColumnProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixColumnProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MatrixColumnPropertiesImpl(): base() {}
  
  public MatrixColumnPropertiesImpl(DocumentFormat.OpenXml.Math.MatrixColumnProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  public Int32? MatrixColumnCount
  {
    get => (System.Int32?)OpenXmlElement?.MatrixColumnCount?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MatrixColumnCount != null)
        {
          if (value is not null)
            OpenXmlElement.MatrixColumnCount.Val = (System.Int32?)value;
          else
            OpenXmlElement.MatrixColumnCount = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MatrixColumnCount = new DocumentFormat.OpenXml.Math.MatrixColumnCount{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  public DocumentModel.Math.HorizontalAlignmentKind? MatrixColumnJustification
  {
    get => (DocumentModel.Math.HorizontalAlignmentKind?)OpenXmlElement?.MatrixColumnJustification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MatrixColumnJustification != null)
        {
          if (value is not null)
            OpenXmlElement.MatrixColumnJustification.Val = (DocumentFormat.OpenXml.Math.HorizontalAlignmentValues?)value;
          else
            OpenXmlElement.MatrixColumnJustification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MatrixColumnJustification = new DocumentFormat.OpenXml.Math.MatrixColumnJustification{ Val = (DocumentFormat.OpenXml.Math.HorizontalAlignmentValues?)value };
        }
      }
    }
  }
  
}
