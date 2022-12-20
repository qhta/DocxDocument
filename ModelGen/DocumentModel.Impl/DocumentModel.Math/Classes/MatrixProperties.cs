namespace DocumentModel.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public partial class MatrixPropertiesImpl: ModelElementImpl, MatrixProperties
{
  public DocumentFormat.OpenXml.Math.MatrixProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MatrixPropertiesImpl(): base() {}
  
  public MatrixPropertiesImpl(DocumentFormat.OpenXml.Math.MatrixProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  public DocumentModel.Math.VerticalAlignmentKind? BaseJustification
  {
    get => (DocumentModel.Math.VerticalAlignmentKind?)OpenXmlElement?.BaseJustification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BaseJustification != null)
        {
          if (value is not null)
            OpenXmlElement.BaseJustification.Val = (DocumentFormat.OpenXml.Math.VerticalAlignmentValues?)value;
          else
            OpenXmlElement.BaseJustification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BaseJustification = new DocumentFormat.OpenXml.Math.BaseJustification{ Val = (DocumentFormat.OpenXml.Math.VerticalAlignmentValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  public DocumentModel.Math.BooleanKind? HidePlaceholder
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.HidePlaceholder?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HidePlaceholder != null)
        {
          if (value is not null)
            OpenXmlElement.HidePlaceholder.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.HidePlaceholder = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HidePlaceholder = new DocumentFormat.OpenXml.Math.HidePlaceholder{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public Int32? RowSpacingRule
  {
    get => (System.Int32?)OpenXmlElement?.RowSpacingRule?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RowSpacingRule != null)
        {
          if (value is not null)
            OpenXmlElement.RowSpacingRule.Val = (System.Int32?)value;
          else
            OpenXmlElement.RowSpacingRule = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RowSpacingRule = new DocumentFormat.OpenXml.Math.RowSpacingRule{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Matrix Column Gap Rule.
  /// </summary>
  public Int32? ColumnGapRule
  {
    get => (System.Int32?)OpenXmlElement?.ColumnGapRule?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ColumnGapRule != null)
        {
          if (value is not null)
            OpenXmlElement.ColumnGapRule.Val = (System.Int32?)value;
          else
            OpenXmlElement.ColumnGapRule = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ColumnGapRule = new DocumentFormat.OpenXml.Math.ColumnGapRule{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Row Spacing (Matrix).
  /// </summary>
  public UInt16? RowSpacing
  {
    get => (System.UInt16?)OpenXmlElement?.RowSpacing?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RowSpacing != null)
        {
          if (value is not null)
            OpenXmlElement.RowSpacing.Val = (System.UInt16?)value;
          else
            OpenXmlElement.RowSpacing = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RowSpacing = new DocumentFormat.OpenXml.Math.RowSpacing{ Val = (System.UInt16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Matrix Column Spacing.
  /// </summary>
  public UInt32? ColumnSpacing
  {
    get => (System.UInt32?)OpenXmlElement?.ColumnSpacing?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ColumnSpacing != null)
        {
          if (value is not null)
            OpenXmlElement.ColumnSpacing.Val = (System.UInt32?)value;
          else
            OpenXmlElement.ColumnSpacing = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ColumnSpacing = new DocumentFormat.OpenXml.Math.ColumnSpacing{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Matrix Column Gap.
  /// </summary>
  public UInt16? ColumnGap
  {
    get => (System.UInt16?)OpenXmlElement?.ColumnGap?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ColumnGap != null)
        {
          if (value is not null)
            OpenXmlElement.ColumnGap.Val = (System.UInt16?)value;
          else
            OpenXmlElement.ColumnGap = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ColumnGap = new DocumentFormat.OpenXml.Math.ColumnGap{ Val = (System.UInt16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public DocumentModel.Math.MatrixColumns? MatrixColumns
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumns>();
        if (item != null)
          return new DocumentModel.Math.MatrixColumnsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumns>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.MatrixColumnsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          return new DocumentModel.Math.ControlPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.ControlPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
