namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Properties.
/// </summary>
public class PreviousTablePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties>, PreviousTableProperties
{
  /// <summary>
  /// TablePositionProperties.
  /// </summary>
  public TablePositionProperties? TablePositionProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TableOverlap.
  /// </summary>
  public TableOverlapKind? TableOverlap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableOverlap>();
        return (TableOverlapKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableOverlap>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TableOverlap{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// BiDiVisual.
  /// </summary>
  public OnOffOnlyKind? BiDiVisual
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDiVisual>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDiVisual>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.BiDiVisual{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TableWidth.
  /// </summary>
  public TableWidthType? TableWidth
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
  /// TableLayout.
  /// </summary>
  public TableLayout? TableLayout
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
  
  /// <summary>
  /// TableLook.
  /// </summary>
  public TableLook? TableLook
  {
    get;
    set;
  }
  
}
