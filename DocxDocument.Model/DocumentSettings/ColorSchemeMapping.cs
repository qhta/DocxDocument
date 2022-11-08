namespace DocxDocument.Model;

public class ColorSchemeMapping: IColorSchemeMapping
{
  public ThemeColorIndex? Accent1 { get; set; }
  public ThemeColorIndex? Accent2 { get; set; }
  public ThemeColorIndex? Accent3 { get; set; }
  public ThemeColorIndex? Accent4 { get; set; }
  public ThemeColorIndex? Accent5 { get; set; }
  public ThemeColorIndex? Accent6 { get; set; }
  public ThemeColorIndex? Background1 { get; set; }
  public ThemeColorIndex? Background2 { get; set; }
  public ThemeColorIndex? Text1 { get; set; }
  public ThemeColorIndex? Text2 { get; set; }
  public ThemeColorIndex? Hyperlink { get; set; }
  public ThemeColorIndex? FollowedHyperlink { get; set; }

}