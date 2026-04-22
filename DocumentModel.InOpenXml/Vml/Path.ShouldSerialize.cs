namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Path
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeValue() => !String.IsNullOrEmpty(Value);
  public bool ShouldSerializeLimo() => !String.IsNullOrEmpty(Limo);
  public bool ShouldSerializeTextboxRectangle() => !String.IsNullOrEmpty(TextboxRectangle);
  public bool ShouldSerializeAllowFill() => AllowFill is not null;
  public bool ShouldSerializeAllowStroke() => AllowStroke is not null;
  public bool ShouldSerializeAllowShading() => AllowShading is not null;
  public bool ShouldSerializeShowArrowhead() => ShowArrowhead is not null;
  public bool ShouldSerializeAllowGradientShape() => AllowGradientShape is not null;
  public bool ShouldSerializeAllowTextPath() => AllowTextPath is not null;
  public bool ShouldSerializeAllowInsetPen() => AllowInsetPen is not null;
  public bool ShouldSerializeConnectionPointType() => ConnectionPointType is not null;
  public bool ShouldSerializeConnectionPoints() => !String.IsNullOrEmpty(ConnectionPoints);
  public bool ShouldSerializeConnectAngles() => !String.IsNullOrEmpty(ConnectAngles);
  public bool ShouldSerializeAllowExtrusion() => AllowExtrusion is not null;
}
