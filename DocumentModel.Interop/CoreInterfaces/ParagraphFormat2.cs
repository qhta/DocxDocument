
namespace DocumentModel.Interop.Core;

public interface ParagraphFormat2: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  MsoParagraphAlignment Alignment { get; set; }
  MsoBaselineAlignment BaselineAlignment { get; set; }
  BulletFormat2 Bullet { get; }
  MsoTriState FarEastLineBreakLevel { get; set; }
  float FirstLineIndent { get; set; }
  MsoTriState HangingPunctuation { get; set; }
  int IndentLevel { get; set; }
  float LeftIndent { get; set; }
  MsoTriState LineRuleAfter { get; set; }
  MsoTriState LineRuleBefore { get; set; }
  MsoTriState LineRuleWithin { get; set; }
  float RightIndent { get; set; }
  float SpaceAfter { get; set; }
  float SpaceBefore { get; set; }
  float SpaceWithin { get; set; }
  TabStops2 TabStops { get; }
  MsoTextDirection TextDirection { get; set; }
  MsoTriState WordWrap { get; set; }
}