namespace DocumentModel.Math;

/// <summary>
/// Equation Array Properties.
/// </summary>
public partial class EquationArrayPropertiesImpl: ModelElementImpl, EquationArrayProperties
{
  public DocumentFormat.OpenXml.Math.EquationArrayProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.EquationArrayProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EquationArrayPropertiesImpl(): base() {}
  
  public EquationArrayPropertiesImpl(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Equation Array Base Justification.
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
  /// Maximum Distribution.
  /// </summary>
  public DocumentModel.Math.BooleanKind? MaxDistribution
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.MaxDistribution?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MaxDistribution != null)
        {
          if (value is not null)
            OpenXmlElement.MaxDistribution.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.MaxDistribution = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MaxDistribution = new DocumentFormat.OpenXml.Math.MaxDistribution{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Object Distribution.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ObjectDistribution
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.ObjectDistribution?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ObjectDistribution != null)
        {
          if (value is not null)
            OpenXmlElement.ObjectDistribution.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.ObjectDistribution = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ObjectDistribution = new DocumentFormat.OpenXml.Math.ObjectDistribution{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
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
  /// Row Spacing (Equation Array).
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
