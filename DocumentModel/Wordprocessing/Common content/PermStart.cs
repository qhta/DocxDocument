namespace DocumentModel.Wordprocessing;

/// <summary>
///   Range permissions in a WordprocessingML document refer to a special kind of bookmark 
///   used to control which subset(s) of users can edit a particular region of a document. 
///   Range permissions specify the user or set of users which are allowed to edit all content between them 
///   whenever the document protection specified by the documentProtection element (§17.15.1.29) is enabled and set to readOnly or comments.
///   <para/>
///   This element specifies the start of a range permission within a WordprocessingML document. 
///   This start marker is matched with the appropriately paired end marker 
///   by matching the value of the Id attribute from the associated permEnd element. 
/// </summary>
public class PermStart: MarkupRangeElement, ICommonContent
{
  /// <summary>
  ///   Specifies the zero-based index of the first column in this row which shall be part of this range permission.
  /// </summary>
  public Int32? ColumnFirst { get; set; }

  /// <summary>
  ///   Specifies the zero-based index of the last column in this row which shall be part of this range permission.
  /// </summary>
  public Int32? ColumnLast { get; set; }

  /// <summary>
  ///   Specifies an alias (or editing group) which shall be used to determine if the current user 
  ///   shall be allowed to edit this range of the document. 
  ///   This mechanism simply provides a set of predefined editing groups 
  ///   which can be associated with user accounts by applications in any desired manner.
  ///   If both the EditorGroup and Ed attributes are present, the value of edGrp is ignored.
  /// </summary>
  public RangePermissionEditingGroupKind? EditorGroup { get; set; }

  /// <summary>
  ///   Specifies a single user for which this range permission shall be enabled 
  ///   (i.e. a user which shall be able to edit this range when document protection is enabled). 
  ///   This editor can be stored in one of the following forms: 
  ///   <list type="bullet">
  ///    <item>
  ///     DOMAIN\username - for users whose access shall be authenticated using the current user's domain credentials 
  ///    </item>
  ///     user@domain.com - for users whose access shall be authenticated using the user's e-mail address as credentials 
  ///    <item>
  ///     user - for users whose access shall be authenticated using the current user's machine credentials  
  ///    </item>
  ///   </list>
  /// </summary>
  public string? Ed { get; set; }

}