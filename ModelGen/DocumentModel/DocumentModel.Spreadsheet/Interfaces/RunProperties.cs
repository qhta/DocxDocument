namespace DocumentModel.Spreadsheet;

/// <summary>
/// Run Properties.
/// </summary>
public interface RunProperties // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Boolean>? Bolds { get ; set; }
  
  public Collection<Boolean>? Italics { get ; set; }
  
  public Collection<Boolean>? Strikes { get ; set; }
  
  public Collection<Boolean>? Condenses { get ; set; }
  
  public Collection<Boolean>? Extends { get ; set; }
  
  public Collection<Boolean>? Outlines { get ; set; }
  
  public Collection<Boolean>? Shadows { get ; set; }
  
  public Collection<UnderlineKind>? Underlines { get ; set; }
  
  public Collection<VerticalAlignmentRunKind>? VerticalTextAlignments { get ; set; }
  
  public Collection<Double>? FontSizes { get ; set; }
  
  public Collection<ColorType>? Colors { get ; set; }
  
  public Collection<String>? RunFonts { get ; set; }
  
  public Collection<Int32>? FontFamilies { get ; set; }
  
  public Collection<Int32>? RunPropertyCharSets { get ; set; }
  
  public Collection<FontSchemeKind>? FontSchemes { get ; set; }
  
}
