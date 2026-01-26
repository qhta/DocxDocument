namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the start of a range permission in a WordprocessingML document.
/// Range permissions are special bookmarks used to control which users or groups can edit a particular region of a document when document protection is enabled and set to read-only or comments. This start marker is matched with the appropriately paired end marker by matching the value of the Id attribute from the associated permEnd element.
/// </summary>
[OpenXmlType(typeof(DXW.PermStart))]
public partial class PermStart : MarkupStartRangeElement<DXW.PermStart, DXW.PermEnd>
{
 /// <summary>
 /// Zero-based index of the first column in this row that is part of this range permission.
 /// </summary>
 public Int32? ColumnFirst { get; set; }
 /// <summary>
 /// Zero-based index of the last column in this row that is part of this range permission.
 /// </summary>
 public Int32? ColumnLast { get; set; }
 /// <summary>
 /// Alias or editing group used to determine if the current user is allowed to edit this range. If both EditorGroup and Ed are present, the value of EditorGroup is ignored.
 /// </summary>
 public RangePermissionEditingGroupKind? EditorGroup { get; set; }
 /// <summary>
 /// Single user for which this range permission is enabled. The editor can be specified as DOMAIN\username, user@domain.com, or user, depending on the authentication method.
 /// </summary>
 public string? Ed { get; set; }
}