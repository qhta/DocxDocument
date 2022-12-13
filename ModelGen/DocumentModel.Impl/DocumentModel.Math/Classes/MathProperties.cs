namespace DocumentModel.Math;

/// <summary>
/// Math Properties.
/// </summary>
public class MathPropertiesImpl: ModelElementImpl, MathProperties
{
  public DocumentFormat.OpenXml.Math.MathProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MathProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MathPropertiesImpl(): base() {}
  
  public MathPropertiesImpl(DocumentFormat.OpenXml.Math.MathProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Math Font.
  /// </summary>
  public String? MathFont
  {
    get => (System.String?)OpenXmlElement?.MathFont?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MathFont != null)
        {
          if (value is not null)
            OpenXmlElement.MathFont.Val = (System.String?)value;
          else
            OpenXmlElement.MathFont = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MathFont = new DocumentFormat.OpenXml.Math.MathFont{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  public DocumentModel.Math.BreakBinaryOperatorKind? BreakBinary
  {
    get => (DocumentModel.Math.BreakBinaryOperatorKind?)OpenXmlElement?.BreakBinary?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BreakBinary != null)
        {
          if (value is not null)
            OpenXmlElement.BreakBinary.Val = (DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues?)value;
          else
            OpenXmlElement.BreakBinary = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BreakBinary = new DocumentFormat.OpenXml.Math.BreakBinary{ Val = (DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  public DocumentModel.Math.BreakBinarySubtractionKind? BreakBinarySubtraction
  {
    get => (DocumentModel.Math.BreakBinarySubtractionKind?)OpenXmlElement?.BreakBinarySubtraction?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.BreakBinarySubtraction != null)
        {
          if (value is not null)
            OpenXmlElement.BreakBinarySubtraction.Val = (DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues?)value;
          else
            OpenXmlElement.BreakBinarySubtraction = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.BreakBinarySubtraction = new DocumentFormat.OpenXml.Math.BreakBinarySubtraction{ Val = (DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  public DocumentModel.Math.BooleanKind? SmallFraction
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.SmallFraction?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SmallFraction != null)
        {
          if (value is not null)
            OpenXmlElement.SmallFraction.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.SmallFraction = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SmallFraction = new DocumentFormat.OpenXml.Math.SmallFraction{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  public DocumentModel.Math.BooleanKind? DisplayDefaults
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.DisplayDefaults?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DisplayDefaults != null)
        {
          if (value is not null)
            OpenXmlElement.DisplayDefaults.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.DisplayDefaults = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DisplayDefaults = new DocumentFormat.OpenXml.Math.DisplayDefaults{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  public UInt32? LeftMargin
  {
    get => (System.UInt32?)OpenXmlElement?.LeftMargin?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LeftMargin != null)
        {
          if (value is not null)
            OpenXmlElement.LeftMargin.Val = (System.UInt32?)value;
          else
            OpenXmlElement.LeftMargin = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LeftMargin = new DocumentFormat.OpenXml.Math.LeftMargin{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  public UInt32? RightMargin
  {
    get => (System.UInt32?)OpenXmlElement?.RightMargin?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RightMargin != null)
        {
          if (value is not null)
            OpenXmlElement.RightMargin.Val = (System.UInt32?)value;
          else
            OpenXmlElement.RightMargin = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RightMargin = new DocumentFormat.OpenXml.Math.RightMargin{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  public DocumentModel.Math.JustificationKind? DefaultJustification
  {
    get => (DocumentModel.Math.JustificationKind?)OpenXmlElement?.DefaultJustification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DefaultJustification != null)
        {
          if (value is not null)
            OpenXmlElement.DefaultJustification.Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value;
          else
            OpenXmlElement.DefaultJustification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DefaultJustification = new DocumentFormat.OpenXml.Math.DefaultJustification{ Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  public UInt32? PreSpacing
  {
    get => (System.UInt32?)OpenXmlElement?.PreSpacing?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PreSpacing != null)
        {
          if (value is not null)
            OpenXmlElement.PreSpacing.Val = (System.UInt32?)value;
          else
            OpenXmlElement.PreSpacing = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PreSpacing = new DocumentFormat.OpenXml.Math.PreSpacing{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  public UInt32? PostSpacing
  {
    get => (System.UInt32?)OpenXmlElement?.PostSpacing?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PostSpacing != null)
        {
          if (value is not null)
            OpenXmlElement.PostSpacing.Val = (System.UInt32?)value;
          else
            OpenXmlElement.PostSpacing = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PostSpacing = new DocumentFormat.OpenXml.Math.PostSpacing{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  public UInt32? InterSpacing
  {
    get => (System.UInt32?)OpenXmlElement?.InterSpacing?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.InterSpacing != null)
        {
          if (value is not null)
            OpenXmlElement.InterSpacing.Val = (System.UInt32?)value;
          else
            OpenXmlElement.InterSpacing = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.InterSpacing = new DocumentFormat.OpenXml.Math.InterSpacing{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  public UInt32? IntraSpacing
  {
    get => (System.UInt32?)OpenXmlElement?.IntraSpacing?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.IntraSpacing != null)
        {
          if (value is not null)
            OpenXmlElement.IntraSpacing.Val = (System.UInt32?)value;
          else
            OpenXmlElement.IntraSpacing = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.IntraSpacing = new DocumentFormat.OpenXml.Math.IntraSpacing{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  public UInt32? WrapIndent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapIndent>();
        return (System.UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapIndent>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.WrapIndent{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Math.BooleanKind? WrapRight
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapRight>();
        return (DocumentModel.Math.BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapRight>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.WrapRight{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Math.LimitLocationKind? IntegralLimitLocation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntegralLimitLocation>();
        return (DocumentModel.Math.LimitLocationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntegralLimitLocation>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.IntegralLimitLocation{ Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Math.LimitLocationKind? NaryLimitLocation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NaryLimitLocation>();
        return (DocumentModel.Math.LimitLocationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NaryLimitLocation>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.NaryLimitLocation{ Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
