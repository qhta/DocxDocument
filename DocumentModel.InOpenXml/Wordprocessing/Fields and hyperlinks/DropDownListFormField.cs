namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of a drop-down list form field in a WordprocessingML document.
/// This class provides properties for the selected item, default item index, and the collection of list entries, enabling advanced configuration and management of interactive drop-down lists within forms and documents.
/// </summary>
[OpenXmlType(typeof(DXW.DropDownListFormField))]
public partial class DropDownListFormField : ModelElement<DXW.DropDownListFormField>
{
 /// <summary>
 /// Index of the currently selected item in the drop-down list.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DropDownListFormField.DropDownListSelection))]
 /// <summary>
 /// Index of the currently selected item in the drop-down list.
 /// </summary>
 [OpenXmlElement(typeof(DXW.DropDownListFormField))]
 public Int32? DropDownListSelection { get => _DropDownListSelection; set => UpdateField(ref _DropDownListSelection, value, nameof(DropDownListSelection)); }

 private Int32? _DropDownListSelection;
 /// <summary>
 /// Index of the default item to be selected when the form is loaded.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DropDownListFormField.DefaultDropDownListItemIndex))]
 /// <summary>
 /// Index of the default item to be selected when the form is loaded.
 /// </summary>
 [OpenXmlElement(typeof(DXW.DropDownListFormField))]
 public Int32? DefaultDropDownListItemIndex { get => _DefaultDropDownListItemIndex; set => UpdateField(ref _DefaultDropDownListItemIndex, value, nameof(DefaultDropDownListItemIndex)); }

 private Int32? _DefaultDropDownListItemIndex;
 /// <summary>
 /// Collection of list entry form fields representing the available options in the drop-down list.
 /// </summary>
 [OpenXmlElement(typeof(DXW.DropDownListFormField))]
 public ListEntryFormFields? ListEntryFormFields { get => _ListEntryFormFields; set => UpdateField(ref _ListEntryFormFields, value, nameof(ListEntryFormFields)); }

 private ListEntryFormFields? _ListEntryFormFields;
}