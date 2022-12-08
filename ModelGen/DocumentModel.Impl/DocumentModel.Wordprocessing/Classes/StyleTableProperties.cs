namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Properties.
/// </summary>
public class StyleTablePropertiesImpl: ModelElementImpl, StyleTableProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.StyleTableProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// TableStyleRowBandSize.
  /// </summary>
  public Int32? TableStyleRowBandSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  public Int32? TableStyleColumnBandSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public TableRowAlignmentKind? TableJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
        return (TableRowAlignmentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TableJustification{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public TableWidthType? TableCellSpacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public TableIndentation? TableIndentation
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public TableBorders? TableBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault
  {
    get;
    set;
  }
  
}
