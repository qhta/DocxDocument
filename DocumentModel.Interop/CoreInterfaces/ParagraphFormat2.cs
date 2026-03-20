
namespace DocumentModel.Interop.Core;

public interface ParagraphFormat2: InteropObject
{
  public MsoParagraphAlignment Alignment { get; set; }
  public MsoBaselineAlignment BaselineAlignment { get; set; }
  public BulletFormat2 Bullet { get; }
  public MsoTriState FarEastLineBreakLevel { get; set; }
  public float FirstLineIndent { get; set; }
  public MsoTriState HangingPunctuation { get; set; }
  public int IndentLevel { get; set; }
  public float LeftIndent { get; set; }
  public MsoTriState LineRuleAfter { get; set; }
  public MsoTriState LineRuleBefore { get; set; }
  public MsoTriState LineRuleWithin { get; set; }
  public float RightIndent { get; set; }
  public float SpaceAfter { get; set; }
  public float SpaceBefore { get; set; }
  public float SpaceWithin { get; set; }
  public TabStops2 TabStops { get; }
  public MsoTextDirection TextDirection { get; set; }
  public MsoTriState WordWrap { get; set; }
}
