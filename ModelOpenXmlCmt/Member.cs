using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlCmt;

/// <summary>
/// Member of the documentation.
/// </summary>
[Index(nameof(ParentMemberId), IsUnique = false)]
[Index(nameof(ShortName), nameof(Params), nameof(ParentMemberId), IsUnique = true)]
[Index(nameof(ShortName), IsUnique = false)]
[Index(nameof(FullName), nameof(OwnerFileId), IsUnique = true)]
[Index(nameof(FullName), IsUnique = false)]
public class Member
{
  /// <summary>
  /// Unique identifier for the member.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the file where the member is placed.
  /// </summary>
  public int OwnerFileId { get; set; }

  /// <summary>
  /// Unique identifier of the parent member.
  /// </summary>
  public int? ParentMemberId { get; set; }

  /// <summary>
  /// LongName of this member.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string FullName { get; set; }

  /// <summary>
  /// ShortName of this member.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string ShortName { get; set; }

  /// <summary>
  /// Parameters of this member.
  /// </summary>
  [MaxLength(255)]
  public string? Params { get; set; }
  
  /// <summary>
  /// Specifies the type of the member.
  /// </summary>
  [Column(TypeName = "byte")]
  [Required]
  public MemberType Type { get; set; }

  /// <summary>
  /// Specifies whether the member has its members.
  /// </summary>
  [Column(TypeName = "bit")]
  public bool HasMembers { get; set; }

  /// <summary>
  /// Text of the first paragraph of the chapter.
  /// </summary>
  [MaxLength(Int32.MaxValue)]
  public string? DescriptionText { get; set; }

  /// <summary>
  /// Navigation property for the file where this member is defined.
  /// </summary>
  [Required]
  public XmlFile OwnerFile { get; set; } = null!;

  /// <summary>
  /// Navigation property for the member where this member is defined.
  /// </summary>
  [Required]
  public Member? ParentMember { get; set; } = null!;

  /// <summary>
  /// Navigation property for the members assigned to this member.
  /// </summary>
  public virtual ICollection<Member> Members { get; set; } = null!;

  /// <summary>
  /// Dictionary of members the members assigned to this member.
  /// </summary>
  [NotMapped]
  public Dictionary<string, Member> MembersDictionary
  {
    get => _MembersDictionary ??= new();
    set => _MembersDictionary = value;
  }
  private Dictionary<string, Member>? _MembersDictionary;

  ///// <summary>
  ///// Navigation property for the comment elements parsed for this member.
  ///// </summary>
  //public virtual ICollection<CommentElement> Comments { get; set; } = null!;

  ///// <summary>
  ///// Dictionary of comment elements parsed for this member. Elements are indexed by their ordinal number.
  ///// </summary>
  //[NotMapped]
  //public Dictionary<int, CommentElement> CommentsDictionary
  //{
  //  get => _CommentsDictionary ??= new();
  //  set => _CommentsDictionary = value;
  //}
  //private Dictionary<int, CommentElement>? _CommentsDictionary;

}