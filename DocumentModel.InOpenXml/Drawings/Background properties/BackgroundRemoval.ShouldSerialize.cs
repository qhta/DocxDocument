namespace DocumentModel.Drawings;

public partial class BackgroundRemoval
{
  public bool ShouldSerializeMarqueeTop() => MarqueeTop is not null;
  public bool ShouldSerializeMarqueeBottom() => MarqueeBottom is not null;
  public bool ShouldSerializeMarqueeLeft() => MarqueeLeft is not null;
  public bool ShouldSerializeMarqueeRight() => MarqueeRight is not null;
  public bool ShouldSerializeForegroundMarks() => ForegroundMarks is not null;
  public bool ShouldSerializeBackgroundMarks() => BackgroundMarks is not null;
}
