namespace DocumentModel.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public class MatrixPropertiesImpl: ModelElementImpl, MatrixProperties
{
  public DocumentFormat.OpenXml.Math.MatrixProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  public VerticalAlignmentKind? BaseJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
        return (VerticalAlignmentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.VerticalAlignmentValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.BaseJustification{ Val = (DocumentFormat.OpenXml.Math.VerticalAlignmentValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  public BooleanKind? HidePlaceholder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HidePlaceholder>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HidePlaceholder>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.HidePlaceholder{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public Int32? RowSpacingRule
  {
    get;
    set;
  }
  
  /// <summary>
  /// Matrix Column Gap Rule.
  /// </summary>
  public Int32? ColumnGapRule
  {
    get;
    set;
  }
  
  /// <summary>
  /// Row Spacing (Matrix).
  /// </summary>
  public UInt16? RowSpacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// Matrix Column Spacing.
  /// </summary>
  public UInt32? ColumnSpacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// Matrix Column Gap.
  /// </summary>
  public UInt16? ColumnGap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public MatrixColumns? MatrixColumns
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
