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
  
  /// <summary>
  /// Math Font.
  /// </summary>
  public String? MathFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathFont>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathFont>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.String?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.MathFont{ Val = (System.String?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Break on Binary Operators.
  /// </summary>
  public BreakBinaryOperatorKind? BreakBinary
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BreakBinary>();
        return (BreakBinaryOperatorKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BreakBinary>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.BreakBinary{ Val = (DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Break on Binary Subtraction.
  /// </summary>
  public BreakBinarySubtractionKind? BreakBinarySubtraction
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BreakBinarySubtraction>();
        return (BreakBinarySubtractionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BreakBinarySubtraction>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.BreakBinarySubtraction{ Val = (DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Small Fraction.
  /// </summary>
  public BooleanKind? SmallFraction
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SmallFraction>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SmallFraction>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.SmallFraction{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Use Display Math Defaults.
  /// </summary>
  public BooleanKind? DisplayDefaults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DisplayDefaults>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DisplayDefaults>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.DisplayDefaults{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  public UInt32? LeftMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LeftMargin>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LeftMargin>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.UInt32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.LeftMargin{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  public UInt32? RightMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.RightMargin>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.RightMargin>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.UInt32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.RightMargin{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Default Justification.
  /// </summary>
  public JustificationKind? DefaultJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DefaultJustification>();
        return (JustificationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.DefaultJustification>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.DefaultJustification{ Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Pre-Equation Spacing.
  /// </summary>
  public UInt32? PreSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSpacing>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSpacing>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.UInt32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.PreSpacing{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Post-Equation Spacing.
  /// </summary>
  public UInt32? PostSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PostSpacing>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PostSpacing>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.UInt32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.PostSpacing{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Inter-Equation Spacing.
  /// </summary>
  public UInt32? InterSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.InterSpacing>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.InterSpacing>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.UInt32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.InterSpacing{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Intra-Equation Spacing.
  /// </summary>
  public UInt32? IntraSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntraSpacing>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntraSpacing>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.UInt32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.IntraSpacing{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
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
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapIndent>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.UInt32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.WrapIndent{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public BooleanKind? WrapRight
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapRight>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.WrapRight>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.WrapRight{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public LimitLocationKind? IntegralLimitLocation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntegralLimitLocation>();
        return (LimitLocationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.IntegralLimitLocation>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.IntegralLimitLocation{ Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public LimitLocationKind? NaryLimitLocation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NaryLimitLocation>();
        return (LimitLocationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NaryLimitLocation>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.NaryLimitLocation{ Val = (DocumentFormat.OpenXml.Math.LimitLocationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
