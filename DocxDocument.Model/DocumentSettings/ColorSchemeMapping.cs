using Microsoft.Office.Interop.Word;

namespace DocxDocument.Model;

public class ColorSchemeMapping: DocxBasedElement<WD.ColorSchemeMapping>, IColorSchemeMapping
{
  public ColorSchemeMapping() : base(new WD.ColorSchemeMapping()) { }

  public ColorSchemeMapping(WD.ColorSchemeMapping wdColorSchemeMapping): base(wdColorSchemeMapping) { }

  public DM.ColorSchemeIndex? Accent1 { get => (DM.ColorSchemeIndex?)DocxElement.Accent1?.Value; set => DocxElement.Accent1 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Accent2 { get => (DM.ColorSchemeIndex?)DocxElement.Accent2?.Value; set => DocxElement.Accent2 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Accent3 { get => (DM.ColorSchemeIndex?)DocxElement.Accent3?.Value; set => DocxElement.Accent3 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Accent4 { get => (DM.ColorSchemeIndex?)DocxElement.Accent4?.Value; set => DocxElement.Accent4 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Accent5 { get => (DM.ColorSchemeIndex?)DocxElement.Accent5?.Value; set => DocxElement.Accent5 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Accent6 { get => (DM.ColorSchemeIndex?)DocxElement.Accent6?.Value; set => DocxElement.Accent6 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Background1 { get => (DM.ColorSchemeIndex?)DocxElement.Background1?.Value; set => DocxElement.Background1 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Background2 { get => (DM.ColorSchemeIndex?)DocxElement.Background2?.Value; set => DocxElement.Background2 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Text1 { get => (DM.ColorSchemeIndex?)DocxElement.Text1?.Value; set => DocxElement.Text1 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Text2 { get => (DM.ColorSchemeIndex?)DocxElement.Text2?.Value; set => DocxElement.Text2 = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? Hyperlink { get => (DM.ColorSchemeIndex?)DocxElement.Hyperlink?.Value; set => DocxElement.Hyperlink = (WD.ColorSchemeIndexValues?)value; }
  public DM.ColorSchemeIndex? FollowedHyperlink { get => (DM.ColorSchemeIndex?)DocxElement.FollowedHyperlink?.Value; set => DocxElement.FollowedHyperlink = (WD.ColorSchemeIndexValues?)value; }

}