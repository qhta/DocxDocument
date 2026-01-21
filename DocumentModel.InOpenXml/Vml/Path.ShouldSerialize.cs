namespace DocumentModel.Vml;

public partial class Path
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeValue() => Value is not null;
  public bool ShouldSerializeLimo() => Limo is not null;
  public bool ShouldSerializeTextboxRectangle() => TextboxRectangle is not null;
  public bool ShouldSerializeAllowFill() => AllowFill is not null;
  public bool ShouldSerializeAllowStroke() => AllowStroke is not null;
  public bool ShouldSerializeAllowShading() => AllowShading is not null;
  public bool ShouldSerializeShowArrowhead() => ShowArrowhead is not null;
  public bool ShouldSerializeAllowGradientShape() => AllowGradientShape is not null;
  public bool ShouldSerializeAllowTextPath() => AllowTextPath is not null;
  public bool ShouldSerializeAllowInsetPen() => AllowInsetPen is not null;
  public bool ShouldSerializeConnectionPointType() => ConnectionPointType is not null;
  public bool ShouldSerializeConnectionPoints() => ConnectionPoints is not null;
  public bool ShouldSerializeConnectAngles() => ConnectAngles is not null;
  public bool ShouldSerializeAllowExtrusion() => AllowExtrusion is not null;
}
