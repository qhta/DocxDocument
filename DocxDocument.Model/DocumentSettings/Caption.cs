using System.Diagnostics;

namespace DocxDocument.Model;

/// <summary>
/// Defines a caption in the collection of captions.
/// </summary>
public class Caption: DocxBasedElement<WD.Caption>, ICaption
{
  public Caption(): base(new WD.Caption())
  {
  }

  public Caption(WD.Caption wdCaption): base(wdCaption)
  {
  }

  /// <summary> 
  /// Include Chapter Number in Field for Caption.
  ///</summary> 
  public bool? ChapterNumber
  {
    get => DocxElement.ChapterNumber?.Value; 
    set => DocxElement.ChapterNumber = value;
  }

  /// <summary> 
  /// Style for Chapter Headings.
  ///</summary> 
  public int? Heading
  {
    get => DocxElement.Heading?.Value; 
    set => DocxElement.Heading = value;
  }

  /// <summary> 
  /// Caption Type Name.
  ///</summary> 
  public string? Name
  {
    get => DocxElement.Name?.Value; 
    set => DocxElement.Name = value;
  }

  /// <summary> 
  /// Do Not Include Name In Caption.
  ///</summary> 
  public bool? NoLabel
  {
    get => DocxElement.NoLabel?.Value; 
    set => DocxElement.NoLabel = value;
  }

  /// <summary> 
  /// Caption Numbering Format.
  ///</summary> 
  public DM.NumberFormat? NumberFormat
  {
    get => (DM.NumberFormat?)DocxElement.NumberFormat?.Value; 
    set => DocxElement.NumberFormat = (WD.NumberFormatValues?)value;
  }

  /// <summary> 
  /// Caption position above or below
  ///</summary> 
  public DM.CaptionPosition? Position
  {
    get => (DM.CaptionPosition?)DocxElement.Position?.Value; 
    set => DocxElement.Position = (WD.CaptionPositionValues?)value;
  }

  /// <summary> 
  /// Separator inserted after chapter number.
  ///</summary> 
  public DM.ChapterSeparator? Separator
  {
    get => (DM.ChapterSeparator?)DocxElement.Separator?.Value; 
    set => DocxElement.Separator = (WD.ChapterSeparatorValues?)value;
  }


}