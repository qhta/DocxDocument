namespace DocumentModel.Wordprocessing
{
  /// <summary>
  /// Methods for interacting with Word content controls, based on Word interop ContentControl methods.
  /// </summary>
  public partial interface ContentControl
  {
    /// <summary>
    /// Deletes the content control from the document, optionally preserving its contents.
    /// </summary>
    void Delete(bool preserveContents = true);

    /// <summary>
    /// Copies the content control and its contents to the clipboard.
    /// </summary>
    void Copy();

    /// <summary>
    /// Cuts the content control and its contents to the clipboard.
    /// </summary>
    void Cut();

    /// <summary>
    /// Sets the text of the content control.
    /// </summary>
    void SetText(string text);

    /// <summary>
    /// Gets the text of the content control.
    /// </summary>
    string GetText();

    /// <summary>
    /// Applies a style to the content control.
    /// </summary>
    void ApplyStyle(string styleName);

    /// <summary>
    /// Clears the contents of the content control.
    /// </summary>
    void Clear();

    /// <summary>
    /// Selects the content control in the document.
    /// </summary>
    void Select();

    /// <summary>
    /// Adds a new item to a ComboBox or DropDownList content control.
    /// </summary>
    void AddItem(string displayText, string value = "");

    /// <summary>
    /// Removes an item from a ComboBox or DropDownList content control by index.
    /// </summary>
    void RemoveItem(int index);

    /// <summary>
    /// Sets the checked state for a CheckBox content control.
    /// </summary>
    void SetChecked(bool isChecked);

    /// <summary>
    /// Gets the checked state for a CheckBox content control.
    /// </summary>
    bool GetChecked();

    /// <summary>
    /// Ungroups a group content control.
    /// </summary>
    void Ungroup();

    /// <summary>
    /// Sets the checked symbol for a checkbox content control.
    /// </summary>
    void SetCheckedSymbol(int characterNumber, string? font = "");

    /// <summary>
    /// Sets the unchecked symbol for a checkbox content control.
    /// </summary>
    void SetUncheckedSymbol(int characterNumber, string? font = "");

    /// <summary>
    /// Sets the placeholder text for the content control.
    /// </summary>
    void SetPlaceholderText(object? buildingBlock = null, object? range = null, string? text = "");
  }
}