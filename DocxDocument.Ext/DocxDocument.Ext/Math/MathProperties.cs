namespace DocumentModel.Math;
public class MathProperties
{
  public MathProperties(DXM.MathProperties properties)
  {
    _properties = properties;
  }

  private DXM.MathProperties _properties;

  public DXM.BreakBinaryOperatorValues? BreakBinary
  {
    get => _properties.BreakBinary?.Val?.Value;
    set
    {
      if (value != null)
        _properties.BreakBinary = new DXM.BreakBinary { Val = value };
      else
        _properties.BreakBinary = null;
    }
  }

  public DXM.BreakBinarySubtractionValues? BreakBinarySubtraction
  {
    get => _properties.BreakBinarySubtraction?.Val?.Value;
    set
    {
      if (value != null)
        _properties.BreakBinarySubtraction = new DXM.BreakBinarySubtraction { Val = value };
      else
        _properties.BreakBinarySubtraction = null;
    }
  }

  public string? MathFont
  {
    get => _properties.MathFont?.Val?.Value;
    set
    {
      if (value != null)
        _properties.MathFont = new DXM.MathFont { Val = value };
      else
        _properties.MathFont = null;
    }
  }


            //builder.AddChild<DocumentFormat.OpenXml.Math.IntegralLimitLocation>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.NaryLimitLocation>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.DefaultJustification>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.SmallFraction>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.DisplayDefaults>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.WrapRight>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.LeftMargin>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.RightMargin>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.PreSpacing>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.PostSpacing>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.InterSpacing>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.IntraSpacing>();
            //builder.AddChild<DocumentFormat.OpenXml.Math.WrapIndent>();
}
