using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public partial class Paragraph: ICollection<ParagraphElement>, IEquatable<Paragraph>, BodyElement
{
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? ParagraphId { get; set; }

  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? TextId { get; set; }

  /// <summary>
  ///   Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  public HexInt? RsidParagraphMarkRevision { get; set; }

  /// <summary>
  ///   Revision Identifier for Paragraph
  /// </summary>
  public HexInt? RsidParagraphAddition { get; set; }

  /// <summary>
  ///   Revision Identifier for Paragraph Deletion
  /// </summary>
  public HexInt? RsidParagraphDeletion { get; set; }

  /// <summary>
  ///   Revision Identifier for Paragraph Properties
  /// </summary>
  public HexInt? RsidParagraphProperties { get; set; }

  /// <summary>
  ///   Default Revision Identifier for Runs
  /// </summary>
  public HexInt? RsidRunAdditionDefault { get; set; }
  
  /// <summary>
  ///   noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoSpellError { get; set; }
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }



  public virtual bool Equals(Paragraph? other)
  {
    if (other== null) return false; 
    if (this.ParagraphId != other.ParagraphId)
      return false;
    if (this.TextId != other.TextId)
      return false;
    if (this.RsidParagraphAddition != other.RsidParagraphAddition)
      return false;
    if (this.RsidParagraphDeletion != other.RsidParagraphDeletion)
      return false;
    if (this.RsidRunAdditionDefault != other.RsidRunAdditionDefault)
      return false;
    if (this.RsidParagraphMarkRevision != other.RsidParagraphMarkRevision)
      return false;
    if (this.RsidParagraphProperties != other.RsidParagraphProperties)
      return false;
    if (this.NoSpellError != other.NoSpellError)
      return false;
    if (this.ParagraphProperties != other.ParagraphProperties)
      return false;
    return true;
  }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }
}