namespace DocxDocument.Model;

/// <summary>
/// Defines a caption in the collection of captions.
/// </summary>
public class Caption: ICaption
{
  /// <summary> 
  /// Include Chapter Number in Field for Caption.
  ///</summary> 
  public bool? ChapterNumber { get; set; }
  /// <summary> 
  /// Style for Chapter Headings.
  ///</summary> 
  public int? Heading { get; set; }
  /// <summary> 
  /// Caption Type Name.
  ///</summary> 
  public string? Name { get; set; }
  /// <summary> 
  /// Do Not Include Name In Caption.
  ///</summary> 
  public bool? NoLabel { get; set; }
  /// <summary> 
  /// Caption Numbering Format.
  ///</summary> 
  public NumberFormat? NumberFormat { get; set; }
  /// <summary> 
  /// Caption position above or below
  ///</summary> 
  public CaptionPosition? Position { get; set; }
  /// <summary> 
  /// Separator inserted after chapter number.
  ///</summary> 
  public ChapterSeparator? Separator { get; set; }


}