namespace DocxDocument.Model;

public interface IColorSchemeMapping
{
  public DM.ColorSchemeIndex? Accent1 { get; set; }
  public DM.ColorSchemeIndex? Accent2 { get; set; }
  public DM.ColorSchemeIndex? Accent3 { get; set; }
  public DM.ColorSchemeIndex? Accent4 { get; set; }
  public DM.ColorSchemeIndex? Accent5 { get; set; }
  public DM.ColorSchemeIndex? Accent6 { get; set; }
  public DM.ColorSchemeIndex? Background1 { get; set; }
  public DM.ColorSchemeIndex? Background2 { get; set; }
  public DM.ColorSchemeIndex? Text1 { get; set; }
  public DM.ColorSchemeIndex? Text2 { get; set; }
  public DM.ColorSchemeIndex? Hyperlink { get; set; }
  public DM.ColorSchemeIndex? FollowedHyperlink { get; set; }

}