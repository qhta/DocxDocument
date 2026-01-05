namespace DocumentModel;

/// <summary>
/// Represents a split button control in the Office ribbon interface that combines a primary action button
/// with a dropdown menu of related options. Split buttons provide quick access to a default action while
/// offering additional choices through the dropdown portion, improving both efficiency and discoverability.
/// </summary>
/// <remarks>
/// <para>
/// Split buttons are a sophisticated ribbon control that merges two interaction models:
/// <list type="bullet">
/// <item><description><b>Primary button:</b> Clicking the main button face executes a default action immediately</description></item>
/// <item><description><b>Dropdown menu:</b> Clicking the dropdown arrow reveals additional related options</description></item>
/// </list>
/// This dual nature makes split buttons ideal for commands with multiple variations where one option
/// is used most frequently.
/// </para>
/// <para>
/// Split buttons are commonly used throughout Office for:
/// <list type="bullet">
/// <item><description><b>Paste operations:</b> Default paste with options for Paste Special, Paste Values, etc.</description></item>
/// <item><description><b>Format commands:</b> Apply default style with variations (Font, Paragraph, Cell formats)</description></item>
/// <item><description><b>Insert operations:</b> Insert common item with alternatives (Table, Picture, Shape types)</description></item>
/// <item><description><b>Save/Export:</b> Quick save with format options (Save As PDF, Save As Template)</description></item>
/// <item><description><b>View modes:</b> Default view with alternative display options</description></item>
/// </list>
/// </para>
/// <para>
/// Split button structure consists of:
/// <list type="bullet">
/// <item><description><b>Primary action:</b> Defined by <see cref="VisibleButton"/> or <see cref="VisibleToggleButton"/></description></item>
/// <item><description><b>Dropdown menu:</b> Defined by <see cref="MenuRegular"/> containing additional options</description></item>
/// <item><description><b>Visual presentation:</b> Icon, label, size, and keytip properties</description></item>
/// <item><description><b>Positioning:</b> Insertion points relative to other ribbon controls</description></item>
/// </list>
/// </para>
/// <para>
/// Split buttons support dynamic behavior through callback functions:
/// <list type="bullet">
/// <item><description><b>getSize:</b> Dynamically determine the button size (large, normal)</description></item>
/// <item><description><b>getEnabled:</b> Control when the button is enabled/disabled</description></item>
/// <item><description><b>getVisible:</b> Control when the button is shown/hidden</description></item>
/// <item><description><b>getShowLabel:</b> Dynamically show/hide the text label</description></item>
/// <item><description><b>getKeytip:</b> Provide context-sensitive keyboard shortcuts</description></item>
/// </list>
/// </para>
/// <para>
/// Design considerations for split buttons:
/// <list type="bullet">
/// <item><description>The primary action should represent the most common use case (typically 70-80% of usage)</description></item>
/// <item><description>Dropdown options should be logically related to the primary action</description></item>
/// <item><description>Keep dropdown menus concise (ideally 3-7 items) to avoid overwhelming users</description></item>
/// <item><description>Use clear, action-oriented labels that indicate what will happen</description></item>
/// <item><description>Consider whether a split button is more appropriate than separate buttons or a gallery</description></item>
/// </list>
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a split button for paste operations
/// var pasteButton = new SplitButton
/// {
///     Id = "customPaste",
///     Size = SizeKind.Large,
///     VisibleButton = new VisibleButton
///     {
///         Id = "pasteButton",
///         Label = "Paste",
///         ImageMso = "Paste",
///         ScreenTip = "Paste (Ctrl+V)",
///         OnAction = "PasteCallback"
///     },
///     MenuRegular = new MenuRegular
///     {
///         Id = "pasteMenu",
///         // Contains Paste Special, Paste Values, etc.
///     }
/// };
/// 
/// // Create a split button with dynamic enabled state
/// var exportButton = new SplitButton
/// {
///     Id = "customExport",
///     GetEnabled = "GetExportEnabled",
///     VisibleButton = new VisibleButton
///     {
///         Id = "exportPdf",
///         Label = "Export to PDF",
///         ImageMso = "ExportToPDF",
///         OnAction = "ExportPdfCallback"
///     },
///     MenuRegular = new MenuRegular
///     {
///         Id = "exportMenu",
///         // Contains Export to Word, Export to Excel, etc.
///     }
/// };
/// 
/// // Create a split button with positioning
/// var formatButton = new SplitButton
/// {
///     Id = "customFormat",
///     IdMso = "Font",
///     InsertAfterMso = "FontSize",
///     VisibleToggleButton = new VisibleToggleButton
///     {
///         Id = "formatToggle",
///         Label = "Format",
///         GetPressed = "IsFormatActive"
///     },
///     MenuRegular = new MenuRegular
///     {
///         Id = "formatOptions"
///     }
/// };
/// </code>
/// </example>
public interface SplitButton :
{
  /// <summary>
  /// Gets or sets the display size of the split button in the ribbon.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The size property determines how the split button is displayed in the ribbon:
  /// <list type="bullet">
  /// <item><description><b>Large:</b> Displays with a large icon (32x32 or larger) and label below, takes more vertical space</description></item>
  /// <item><description><b>Normal:</b> Displays with a small icon (16x16) and label to the right, more compact</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Size affects not only visual appearance but also user interaction:
  /// <list type="bullet">
  /// <item><description>Large split buttons are more prominent and easier to click, suitable for frequently used commands</description></item>
  /// <item><description>Normal split buttons conserve ribbon space, appropriate for secondary commands</description></item>
  /// <item><description>Large buttons typically appear in the first group of a ribbon tab</description></item>
  /// <item><description>The dropdown arrow is proportionally sized based on the button size</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public SizeKind? Size { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically determines the button size.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getSize callback enables dynamic size adjustment based on runtime conditions such as:
  /// <list type="bullet">
  /// <item><description>Ribbon width and available space (responsive design)</description></item>
  /// <item><description>User preferences or application settings</description></item>
  /// <item><description>Context or document state</description></item>
  /// <item><description>Importance of the command in the current workflow</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a ribbon control parameter and should return a <see cref="SizeKind"/> value.
  /// Dynamic sizing can improve ribbon usability by emphasizing important commands or adapting to available space.
  /// </para>
  /// </remarks>
  public string? GetSize { get; set; }

  /// <summary>
  /// Gets or sets whether the split button is enabled and can be interacted with.
  /// </summary>
  /// <remarks>
  /// <para>
  /// When a split button is disabled:
  /// <list type="bullet">
  /// <item><description>Both the primary button and dropdown arrow become inactive</description></item>
  /// <item><description>Visual appearance changes (grayed out icon and text)</description></item>
  /// <item><description>Clicking the button has no effect</description></item>
  /// <item><description>Tooltips may indicate why the button is disabled</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common reasons for disabling split buttons:
  /// <list type="bullet">
  /// <item><description>Required preconditions are not met (no selection, incompatible content)</description></item>
  /// <item><description>Operation is not applicable to current context</description></item>
  /// <item><description>Document is read-only or protected</description></item>
  /// <item><description>Feature requires specific document format or version</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically determines whether the button is enabled.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getEnabled callback allows the split button's enabled state to respond to:
  /// <list type="bullet">
  /// <item><description>Current document selection or cursor position</description></item>
  /// <item><description>Document state (modified, saved, protected)</description></item>
  /// <item><description>Available features or installed components</description></item>
  /// <item><description>User permissions or license status</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a ribbon control parameter and should return a boolean value.
  /// Office calls this function when the ribbon needs to update, such as when selection changes or
  /// the ribbon is invalidated programmatically.
  /// </para>
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Gets or sets the unique identifier for this split button.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The ID is used to uniquely identify this split button for:
  /// <list type="bullet">
  /// <item><description>Referencing in callback functions</description></item>
  /// <item><description>Programmatic ribbon invalidation and updates</description></item>
  /// <item><description>Debugging and troubleshooting</description></item>
  /// <item><description>Maintaining consistent naming across customizations</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The ID should be unique within the scope of the ribbon tab or group where the split button appears.
  /// Use descriptive names that indicate the button's purpose (e.g., "customPasteSplitButton", "exportFormatButton").
  /// </para>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  /// Gets or sets the namespace-qualified identifier for this split button.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The qualified ID allows split buttons to be organized into namespaces, preventing naming conflicts
  /// when multiple add-ins customize the same ribbon area. The format is typically "namespace:localId"
  /// where namespace identifies the add-in or feature group.
  /// </para>
  /// <para>
  /// Qualified IDs are particularly important when:
  /// <list type="bullet">
  /// <item><description>Multiple add-ins extend the same ribbon tab or group</description></item>
  /// <item><description>Creating suites of related controls that need consistent namespacing</description></item>
  /// <item><description>Avoiding ID collisions in complex ribbon customizations</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  /// Gets or sets an arbitrary tag value for application-specific purposes.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The tag property provides flexible storage for custom metadata used in application logic.
  /// Unlike ID properties, tags don't need to be unique and can be shared across multiple controls.
  /// Common uses include:
  /// <list type="bullet">
  /// <item><description>Categorizing controls by feature or module</description></item>
  /// <item><description>Storing data binding keys or references</description></item>
  /// <item><description>Flagging controls with special handling requirements</description></item>
  /// <item><description>Implementing custom control behaviors or grouping logic</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  /// Gets or sets the Microsoft Office built-in control identifier to customize or reference.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The idMso (ID Microsoft Office) property serves two purposes:
  /// <list type="bullet">
  /// <item><description><b>Customization:</b> Modify the appearance or behavior of a built-in Office split button</description></item>
  /// <item><description><b>Positioning reference:</b> Used with insert properties to position custom controls relative to built-in ones</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// When customizing built-in split buttons, you can override properties like visibility, enabled state,
  /// or add additional menu items to the dropdown. This allows integration of custom functionality
  /// with Office's native commands.
  /// </para>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  /// Gets or sets the ID of a built-in Office control after which this split button should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertAfterMso property allows precise positioning of custom split buttons within the ribbon
  /// by placing them immediately after built-in Office controls. This is essential for:
  /// <list type="bullet">
  /// <item><description>Integrating custom commands with related Office features</description></item>
  /// <item><description>Maintaining logical grouping of related functionality</description></item>
  /// <item><description>Creating intuitive workflows by placing commands in expected locations</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// For example, setting insertAfterMso="Paste" places the custom split button immediately after
  /// the built-in Paste button in the ribbon.
  /// </para>
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  /// Gets or sets the ID of a built-in Office control before which this split button should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertBeforeMso property allows precise positioning of custom split buttons by placing them
  /// immediately before built-in Office controls. This is useful when you want custom functionality
  /// to appear earlier in a group or when the logical flow requires placement before a specific command.
  /// </para>
  /// <para>
  /// For example, setting insertBeforeMso="Copy" places the custom split button immediately before
  /// the built-in Copy button in the ribbon.
  /// </para>
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  /// Gets or sets the qualified ID of a custom control after which this split button should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertAfterQualifiedId property enables positioning relative to other custom controls
  /// (rather than built-in Office controls). This is important when multiple add-ins or customizations
  /// need to coordinate their ribbon layout and establish a specific order for custom controls.
  /// </para>
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  /// Gets or sets the qualified ID of a custom control before which this split button should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertBeforeQualifiedId property enables positioning relative to other custom controls
  /// (rather than built-in Office controls). This allows fine-grained control over the order of
  /// custom split buttons and other custom controls in the ribbon.
  /// </para>
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  /// Gets or sets whether the split button is visible in the ribbon.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Visibility control allows split buttons to appear or disappear based on:
  /// <list type="bullet">
  /// <item><description>Application context or document type</description></item>
  /// <item><description>User permissions or license features</description></item>
  /// <item><description>Feature availability or configuration</description></item>
  /// <item><description>Workflow state or mode</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Hidden controls do not occupy ribbon space and cannot be accessed via keyboard navigation.
  /// Use visibility sparingly to avoid confusing users with disappearing commands.
  /// </para>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically determines whether the button is visible.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getVisible callback enables dynamic visibility based on runtime conditions such as:
  /// <list type="bullet">
  /// <item><description>Document type or format (show only for Word documents, hide for templates)</description></item>
  /// <item><description>User role or permissions (admin-only commands)</description></item>
  /// <item><description>Feature availability (license-dependent features)</description></item>
  /// <item><description>Application mode or state</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a ribbon control parameter and should return a boolean value.
  /// Use dynamic visibility to create context-aware ribbons that adapt to user needs.
  /// </para>
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Gets or sets the keyboard shortcut (keytip) that activates this split button.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Keytips appear when users press the Alt key, displaying keyboard shortcuts for ribbon controls.
  /// For split buttons, keytips should be:
  /// <list type="bullet">
  /// <item><description>Short (1-3 characters) for quick access</description></item>
  /// <item><description>Mnemonic where possible (first letter of label)</description></item>
  /// <item><description>Unique within the ribbon tab or group</description></item>
  /// <item><description>Memorable and intuitive for users</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// When a keytip is activated, it triggers the primary action of the split button (not the dropdown).
  /// Users typically need an additional key to access the dropdown menu via keyboard.
  /// </para>
  /// </remarks>
  public string? Keytip { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically provides the keytip value.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getKeytip callback allows context-sensitive keyboard shortcuts that adapt to:
  /// <list type="bullet">
  /// <item><description>User language or locale (localized keytips)</description></item>
  /// <item><description>Document context or mode</description></item>
  /// <item><description>Keytip conflicts with other controls</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a ribbon control parameter and should return a string value.
  /// </para>
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Gets or sets whether the text label is displayed alongside the icon.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Label visibility affects both usability and ribbon space utilization:
  /// <list type="bullet">
  /// <item><description><b>Show label:</b> Improves discoverability and clarity, especially for new users</description></item>
  /// <item><description><b>Hide label:</b> Conserves ribbon space, suitable for well-known commands with clear icons</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Typically, large split buttons show labels while normal-sized buttons may hide labels to save space.
  /// Consider icon clarity and user familiarity when deciding whether to show labels.
  /// </para>
  /// </remarks>
  public bool? ShowLabel { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically determines whether the label is shown.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getShowLabel callback enables dynamic label visibility based on:
  /// <list type="bullet">
  /// <item><description>Ribbon width and available space (responsive design)</description></item>
  /// <item><description>User preferences or accessibility settings</description></item>
  /// <item><description>Button size or layout context</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a ribbon control parameter and should return a boolean value.
  /// Dynamic label visibility can improve ribbon responsiveness and accommodate different display configurations.
  /// </para>
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Gets or sets the primary button component of the split button that executes the default action.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The visible button represents the main action portion of the split button. When users click
  /// the button face (not the dropdown arrow), this button's action is executed. The button includes:
  /// <list type="bullet">
  /// <item><description>Icon and label for visual identification</description></item>
  /// <item><description>OnAction callback for the primary command</description></item>
  /// <item><description>ScreenTip and SuperTip for help and guidance</description></item>
  /// <item><description>Size and styling properties</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The primary button should represent the most frequently used option from the dropdown menu.
  /// Choose an action that makes sense as the default for 70-80% of use cases.
  /// </para>
  /// </remarks>
  public VisibleButton? VisibleButton { get; set; }

  /// <summary>
  /// Gets or sets the primary toggle button component of the split button that toggles a feature on/off.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The visible toggle button provides a primary action that switches between two states (on/off, pressed/unpressed).
  /// This is used when the split button's default action is a toggle operation with additional options in the dropdown.
  /// </para>
  /// <para>
  /// Common examples include:
  /// <list type="bullet">
  /// <item><description>Bold/Italic formatting with font style variations in the dropdown</description></item>
  /// <item><description>View mode toggle with additional view options in the menu</description></item>
  /// <item><description>Filter toggle with filter configuration options</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The toggle button's pressed state should be managed through the getPressed callback to reflect
  /// the current state of the feature being toggled.
  /// </para>
  /// </remarks>
  public VisibleToggleButton? VisibleToggleButton { get; set; }

  /// <summary>
  /// Gets or sets the dropdown menu component of the split button containing additional options.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The menu component contains the alternative actions or options related to the primary button.
  /// The menu appears when users click the dropdown arrow portion of the split button and typically includes:
  /// <list type="bullet">
  /// <item><description><b>Variations:</b> Different ways to perform the primary action (Paste, Paste Special, Paste Values)</description></item>
  /// <item><description><b>Related commands:</b> Actions similar to the primary command</description></item>
  /// <item><description><b>Recent items:</b> Recently used options or settings</description></item>
  /// <item><description><b>Configuration:</b> Settings or preferences for the primary action</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Menu design best practices for split buttons:
  /// <list type="bullet">
  /// <item><description>Keep menus concise (3-7 items is ideal)</description></item>
  /// <item><description>Place most common option first (often duplicating the primary action)</description></item>
  /// <item><description>Group related items with separators if needed</description></item>
  /// <item><description>Use clear, action-oriented labels</description></item>
  /// <item><description>Consider whether submenu nesting is appropriate (usually avoid deep nesting)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The menu can contain buttons, toggle buttons, checkboxes, galleries, or even nested submenus,
  /// providing rich functionality while maintaining the quick-access benefit of the primary action.
  /// </para>
  /// </remarks>
  public MenuRegular? MenuRegular { get; set; }
}