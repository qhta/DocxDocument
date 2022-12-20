namespace DocxDocument.Model;

public class ParagraphProperties
{
  public Color? BackgroundColor { get; set; } 
  public string? border { get; set; } 
  public string? borderBottom { get; set; } 
  public string? borderLeft { get; set; } 
  public string? borderRight { get; set; } 
  public string? borderTop { get; set; } 
  public BreakAfterBefore? breakAfter { get; set; } 
  public BreakAfterBefore? breakBefore { get; set; } 
  public HyphenationKeep? hyphenationKeep { get; set; }
  public int? HyphenationLadderCount { get; set; } // null = no limit
  public bool? KeepTogether { get; set; } 
  public bool? KeepWithNext { get; set; } 
  public string? lineHeight { get; set; } 
  public string? margin { get; set; } 
  public string? marginBottom { get; set; } 
  public string? marginLeft { get; set; } 
  public string? marginRight { get; set; } 
  public string? marginTop { get; set; } 
  public int? orphans { get; set; } 
  public string? padding { get; set; } 
  public string? paddingBottom { get; set; } 
  public string? paddingLeft { get; set; } 
  public string? paddingRight { get; set; } 
  public string? paddingTop { get; set; } 
  public string? textAlign { get; set; } 
  public string? textAlignLast { get; set; } 
  public string? textIndent { get; set; } 
  public int? widows { get; set; } 
  public string? autoTextIndent { get; set; } 
  public string? backgroundTransparency { get; set; } 
  public string? borderLineWidth { get; set; } 
  public string? borderLineWidthBottom { get; set; } 
  public string? borderLineWidthLeft { get; set; } 
  public string? borderLineWidthRight { get; set; } 
  public string? borderLineWidthTop { get; set; } 
  public string? contextualSpacing { get; set; } 
  public string? fontIndependentLineSpacing { get; set; } 
  public string? joinBorder { get; set; } 
  public string? justifySingleWord { get; set; } 
  public string? lineBreak { get; set; } 
  public string? lineHeightAtLeast { get; set; } 
  public string? lineSpacing { get; set; } 
  public string? pageNumber { get; set; } 
  public string? punctuationWrap { get; set; } 
  public string? registerTrue { get; set; } 
  public string? shadow { get; set; } 
  public string? snapToLayoutGrid { get; set; } 
  public string? tabStopDistance { get; set; } 
  public string? textAutospace { get; set; } 
  public string? verticalAlign { get; set; } 
  public string? writingMode { get; set; } 
  public string? writingModeAutomatic { get; set; }
  public string? lineNumber { get; set; }
  public string? numberLines { get; set; }

  //The<style:paragraph-properties> element has the following child elements: <style:background-image> 17.3, <style:drop-cap> 17.9 and<style:tab-stops>

  public Justification? Justification { get; set; } = DocxDocument.Model.Justification.Justified;
}