
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a combo box control on a command bar.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox?view=office-pia"/>
public interface ICommandBarComboBox : ICommandBarControl
{
  /// <summary>
  /// Gets or sets the `DropDownLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.dropdownlines?view=office-pia"/>
  public int DropDownLines { get; set; }
  /// <summary>
  /// Gets or sets the `DropDownWidth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.dropdownwidth?view=office-pia"/>
  public int DropDownWidth { get; set; }
  /// <summary>
  /// Gets or sets the `List` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.list?view=office-pia"/>
  public string List { get; set; }
  /// <summary>
  /// Gets the `ListCount` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.listcount?view=office-pia"/>
  public int ListCount { get; }
  /// <summary>
  /// Gets or sets the `ListHeaderCount` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.listheadercount?view=office-pia"/>
  public int ListHeaderCount { get; set; }
  /// <summary>
  /// Gets or sets the `ListIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.listindex?view=office-pia"/>
  public int ListIndex { get; set; }
  /// <summary>
  /// Gets or sets the `Style` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.style?view=office-pia"/>
  public ComboStyle Style { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets the `InstanceIdPtr` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.instanceidptr?view=office-pia"/>
  public object InstanceIdPtr { get; }


  #region methods

  /// <summary>
  /// Adds an item to the combo box list.
  /// </summary>
  /// <param name="Text">The `Text` parameter.</param>
  /// <param name="Index">The `Index` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.additem?view=office-pia"/>
  public void AddItem(string Text, object Index);
  /// <summary>
  /// Clears all items from the combo box list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.clear?view=office-pia"/>
  public void Clear();
  /// <summary>
  /// Removes an item from the combo box list.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarcombobox.removeitem?view=office-pia"/>
  public void RemoveItem(int Index);

  #endregion methods
}

