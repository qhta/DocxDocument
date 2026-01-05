namespace DocumentModel;

/// <summary>
/// Represents a simplified split button control for use in context menus, Backstage menus, and other
/// non-ribbon Office UI contexts. Unlike the full <see cref="SplitButton"/> control, this regular variant
/// omits ribbon-specific properties (like size) and focuses on core split button functionality.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="SplitButtonRegular"/> is a streamlined version of the split button control designed for
/// use outside the main Office ribbon, particularly in:
/// <list type="bullet">
/// <item><description><b>Context menus:</b> Right-click menus with split button options</description></item>
/// <item><description><b>Backstage menus:</b> File tab pages and Backstage navigation</description></item>
/// <item><description><b>Dialog boxes:</b> Custom dialogs requiring split button controls</description></item>
/// <item><description><b>Task panes:</b> Add-in interfaces with split button functionality</description></item>
/// </list>
/// </para>
/// <para>
/// Key differences between <see cref="SplitButtonRegular"/> and <see cref="SplitButton"/>:
/// <list type="bullet">
/// <item><description><b>No Size property:</b> Regular split buttons don't have configurable sizes (large/normal) since they're not in the ribbon</description></item>
/// <item><description><b>Context-specific:</b> Designed for menus and dialogs rather than ribbon tabs and groups</description></item>
/// <item><description><b>Simplified layout:</b> Adapts to the layout constraints of menus and non-ribbon contexts</description></item>
/// <item><description><b>Same core functionality:</b> Still combines a primary action with a dropdown menu of options</description></item>
/// </list>
/// </para>
/// <para>
/// Regular split buttons maintain the fundamental split button behavior:
/// <list type="bullet">
/// <item><description><b>Primary action:</b> Clicking the button face executes a default command</description></item>
/// <item><description><b>Dropdown menu:</b> Clicking the arrow reveals additional related options</description></item>
/// <item><description><b>Efficiency:</b> Provides quick access to common actions while offering alternatives</description></item>
/// <item><description><b>Discoverability:</b> Users can explore related options without cluttering the interface</description></item>
/// </list>
/// </para>
/// <para>
/// Common use cases for regular split buttons:
/// <list type="bullet">
/// <item><description><b>Context menu operations:</b> Paste with options (Paste Special, Paste Values) in right-click menus</description></item>
/// <item><description><b>Backstage actions:</b> Save with format options (Save As PDF, Save As Template) in File tab</description></item>
/// <item><description><b>Task pane commands:</b> Export with destination choices in add-in panels</description></item>
/// <item><description><b>Dialog actions:</b> Accept with variations (OK, OK and New, OK and Close) in custom dialogs</description></item>
/// </list>
/// </para>
/// <para>
/// Regular split buttons support the same dynamic behavior as ribbon split buttons through callback functions:
/// <list type="bullet">
/// <item><description><b>getEnabled:</b> Dynamically enable/disable based on context</description></item>
/// <item><description><b>getVisible:</b> Show/hide based on conditions</description></item>
/// <item><description><b>getShowLabel:</b> Control label visibility</description></item>
/// <item><description><b>getKeytip:</b> Provide keyboard access</description></item>
/// </list>
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Regular split button for a context menu
/// var contextMenuSplitButton = new SplitButtonRegular
/// {
///     Id = "customPasteMenu",
///     VisibleButton = new VisibleButton
///     {
///         Id = "pasteButton",
///         Label = "Paste",
///         ImageMso = "Paste",
///         OnAction = "PasteCallback"
///     },
///     MenuRegular = new MenuRegular
///     {
///         Id = "pasteOptions",
///         // Contains Paste Special, Paste Values, etc.
///     }
/// };
/// 
/// // Regular split button for Backstage with positioning
/// var backstageSplitButton = new SplitButtonRegular
/// {
///     Id = "customExport",
///     InsertAfterMso = "FileSave",
///     VisibleButton = new VisibleButton
///     {
///         Id = "exportPdf",
///         Label = "Export to PDF",
///         ImageMso = "ExportToPDF",
///         ScreenTip = "Export document as PDF",
///         OnAction = "ExportPdfCallback"
///     },
///     MenuRegular = new MenuRegular
///     {
///         Id = "exportMenu",
///         // Contains other export format options
///     }
/// };
/// 
/// // Regular split button with dynamic state
/// var taskPaneSplitButton = new SplitButtonRegular
/// {
///     Id = "insertTemplate",
///     GetEnabled = "GetInsertEnabled",
///     GetVisible = "GetInsertVisible",
///     VisibleButton = new VisibleButton
///     {
///         Id = "insertDefault",
///         Label = "Insert Default",
///         OnAction = "InsertDefaultCallback"
///     },
///     MenuRegular = new MenuRegular
///     {
///         Id = "templateChoices"
///     }
/// };
/// </code>
/// </example>
public interface SplitButtonRegular :
{
  /// <summary>
  /// Gets or sets whether the split button is enabled and can be interacted with.
  /// </summary>
  /// <remarks>
  /// <para>
  /// When a regular split button is disabled:
  /// <list type="bullet">
  /// <item><description>Both the primary button and dropdown arrow become inactive</description></item>
  /// <item><description>Visual appearance changes (grayed out icon and text)</description></item>
  /// <item><description>Clicking the button has no effect</description></item>
  /// <item><description>Tooltips may indicate why the button is disabled</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common reasons for disabling regular split buttons in menus and dialogs:
  /// <list type="bullet">
  /// <item><description>Required preconditions are not met (no selection, no clipboard content)</description></item>
  /// <item><description>Operation is not applicable to current context or document state</description></item>
  /// <item><description>Document is read-only or protected</description></item>
  /// <item><description>Feature requires specific conditions (network connection, external data source)</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically determines whether the button is enabled.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getEnabled callback allows the regular split button's enabled state to respond dynamically to:
  /// <list type="bullet">
  /// <item><description>Current selection or cursor position when context menu appears</description></item>
  /// <item><description>Clipboard state (for paste operations)</description></item>
  /// <item><description>Document or data availability</description></item>
  /// <item><description>User permissions or feature availability</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a control parameter and should return a boolean value.
  /// Office calls this function when menus are displayed or when the interface needs to update.
  /// </para>
  /// </remarks>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Gets or sets the unique identifier for this split button.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The ID is used to uniquely identify this regular split button for:
  /// <list type="bullet">
  /// <item><description>Referencing in callback functions</description></item>
  /// <item><description>Programmatic UI updates and invalidation</description></item>
  /// <item><description>Debugging and troubleshooting menu customizations</description></item>
  /// <item><description>Maintaining consistent naming across context menus and Backstage pages</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The ID should be unique within the scope of the context menu, Backstage page, or dialog where
  /// the split button appears. Use descriptive names that indicate context and purpose
  /// (e.g., "contextMenuPaste", "backstageExport", "dialogAccept").
  /// </para>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  /// Gets or sets the namespace-qualified identifier for this split button.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The qualified ID allows regular split buttons to be organized into namespaces, preventing naming
  /// conflicts when multiple add-ins customize the same context menu or Backstage area. The format is
  /// typically "namespace:localId" where namespace identifies the add-in or feature group.
  /// </para>
  /// <para>
  /// Qualified IDs are particularly important for:
  /// <list type="bullet">
  /// <item><description>Multiple add-ins extending the same context menu</description></item>
  /// <item><description>Backstage customizations from different sources</description></item>
  /// <item><description>Avoiding ID collisions in complex menu hierarchies</description></item>
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
  /// <item><description>Categorizing menu items by feature area or operation type</description></item>
  /// <item><description>Storing data binding keys or command parameters</description></item>
  /// <item><description>Flagging controls with special handling requirements</description></item>
  /// <item><description>Implementing custom menu behavior or grouping logic</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  /// Gets or sets the Microsoft Office built-in control identifier to customize or reference.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The idMso (ID Microsoft Office) property serves two purposes for regular split buttons:
  /// <list type="bullet">
  /// <item><description><b>Customization:</b> Modify appearance or behavior of a built-in Office split button in menus</description></item>
  /// <item><description><b>Positioning reference:</b> Used with insert properties to position custom buttons relative to built-in ones</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// When customizing built-in split buttons, you can override properties like visibility or enabled state,
  /// or add additional items to the dropdown menu. This allows seamless integration of custom functionality
  /// with Office's native context menu and Backstage commands.
  /// </para>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  /// Gets or sets the ID of a built-in Office control after which this split button should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertAfterMso property allows precise positioning of custom split buttons within context menus
  /// or Backstage interfaces by placing them immediately after built-in Office controls. This is essential for:
  /// <list type="bullet">
  /// <item><description>Integrating custom commands with related Office features</description></item>
  /// <item><description>Maintaining logical grouping in context menus</description></item>
  /// <item><description>Creating intuitive workflows by placing commands where users expect them</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// For example, setting insertAfterMso="Paste" in a context menu places the custom split button
  /// immediately after the built-in Paste command.
  /// </para>
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  /// Gets or sets the ID of a built-in Office control before which this split button should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertBeforeMso property allows precise positioning of custom split buttons by placing them
  /// immediately before built-in Office controls in menus or Backstage pages. This is useful when custom
  /// functionality should appear earlier in the menu sequence or when logical flow requires placement
  /// before a specific command.
  /// </para>
  /// <para>
  /// For example, setting insertBeforeMso="Copy" in a context menu places the custom split button
  /// immediately before the built-in Copy command.
  /// </para>
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  /// Gets or sets the qualified ID of a custom control after which this split button should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertAfterQualifiedId property enables positioning relative to other custom controls
  /// (rather than built-in Office controls) in menus and Backstage pages. This is important when multiple
  /// add-ins or customizations need to coordinate their layout and establish a specific order for custom controls.
  /// </para>
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  /// Gets or sets the qualified ID of a custom control before which this split button should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertBeforeQualifiedId property enables positioning relative to other custom controls
  /// (rather than built-in Office controls) in menus and Backstage pages. This allows fine-grained
  /// control over the order of custom split buttons and other custom controls.
  /// </para>
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  /// Gets or sets whether the split button is visible in the menu or interface.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Visibility control allows regular split buttons to appear or disappear in context menus,
  /// Backstage pages, or dialogs based on:
  /// <list type="bullet">
  /// <item><description>Context of the right-click (what was clicked, current selection)</description></item>
  /// <item><description>Document state or format</description></item>
  /// <item><description>User permissions or feature availability</description></item>
  /// <item><description>Application mode or workflow state</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Hidden controls do not appear in menus and cannot be accessed. Use visibility to create
  /// context-aware menus that only show relevant commands for the current situation.
  /// </para>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically determines whether the button is visible.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getVisible callback enables dynamic visibility for regular split buttons based on runtime conditions:
  /// <list type="bullet">
  /// <item><description>What was clicked to show the context menu (text, table, image, shape)</description></item>
  /// <item><description>Current selection state or cursor position</description></item>
  /// <item><description>Document type, format, or protection status</description></item>
  /// <item><description>User role, permissions, or feature availability</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a control parameter and should return a boolean value.
  /// Dynamic visibility creates intelligent, context-aware menus that adapt to user needs.
  /// </para>
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Gets or sets the keyboard shortcut (keytip) that activates this split button.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Keytips provide keyboard access to regular split buttons in menus and Backstage pages.
  /// In context menus, keytips appear as underlined letters that can be pressed to activate commands.
  /// For split buttons, keytips should be:
  /// <list type="bullet">
  /// <item><description>Short (typically 1 character) for quick access</description></item>
  /// <item><description>Mnemonic where possible (first letter of label)</description></item>
  /// <item><description>Unique within the menu or page</description></item>
  /// <item><description>Intuitive and easy to remember</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// When a keytip is activated in a context menu or Backstage, it triggers the primary action
  /// of the split button (not the dropdown). Additional keyboard interaction may be needed to access
  /// the dropdown menu items.
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
  /// <item><description>Menu context or document state</description></item>
  /// <item><description>Keytip conflicts with other menu items</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a control parameter and should return a string value.
  /// </para>
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Gets or sets whether the text label is displayed alongside the icon.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Label visibility in menus and Backstage affects usability:
  /// <list type="bullet">
  /// <item><description><b>Show label:</b> Standard for context menus and most Backstage buttons, improves clarity</description></item>
  /// <item><description><b>Hide label:</b> Rarely used for regular split buttons, may be appropriate for icon-only toolbars</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Context menus typically always show labels for clarity, while Backstage pages may offer more
  /// flexibility in label display based on layout and space constraints.
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
  /// <item><description>Available space in Backstage layouts</description></item>
  /// <item><description>User preferences or accessibility settings</description></item>
  /// <item><description>Context or importance of the command</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a control parameter and should return a boolean value.
  /// </para>
  /// </remarks>
  public string? GetShowLabel { get; set; }

  /// <summary>
  /// Gets or sets the primary button component of the split button that executes the default action.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The visible button represents the main action portion of the regular split button. When users click
  /// the button face (not the dropdown arrow), this button's action is executed. The button includes:
  /// <list type="bullet">
  /// <item><description>Icon and label for visual identification in menus</description></item>
  /// <item><description>OnAction callback for the primary command</description></item>
  /// <item><description>ScreenTip for help text (especially in Backstage)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The primary button should represent the most frequently used option from the dropdown menu.
  /// In context menus, this is typically the default action users expect when clicking on the menu item.
  /// </para>
  /// </remarks>
  public VisibleButton? VisibleButton { get; set; }

  /// <summary>
  /// Gets or sets the primary toggle button component of the split button that toggles a feature on/off.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The visible toggle button provides a primary action that switches between two states (on/off, pressed/unpressed).
  /// This is used when the regular split button's default action is a toggle operation with additional
  /// options available in the dropdown.
  /// </para>
  /// <para>
  /// Common examples in context menus and Backstage include:
  /// <list type="bullet">
  /// <item><description>View mode toggles with additional view options</description></item>
  /// <item><description>Feature enable/disable with configuration options in the dropdown</description></item>
  /// <item><description>Filter toggles with filter settings in the menu</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public VisibleToggleButton? VisibleToggleButton { get; set; }

  /// <summary>
  /// Gets or sets the dropdown menu component of the split button containing additional options.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The menu component contains alternative actions or options related to the primary button.
  /// The menu appears when users click the dropdown arrow portion of the split button and typically includes:
  /// <list type="bullet">
  /// <item><description><b>Variations:</b> Different ways to perform the primary action (Paste, Paste Special, Paste Values in context menus)</description></item>
  /// <item><description><b>Related commands:</b> Actions similar to the primary command</description></item>
  /// <item><description><b>Format options:</b> Different output formats or destinations (Save As PDF, Save As Word)</description></item>
  /// <item><description><b>Settings:</b> Configuration options for the primary action</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Menu design for regular split buttons in context menus and Backstage:
  /// <list type="bullet">
  /// <item><description>Keep menus concise (3-7 items ideal)</description></item>
  /// <item><description>Place most common option first or match it to the primary action</description></item>
  /// <item><description>Use separators to group related items</description></item>
  /// <item><description>Provide clear, action-oriented labels</description></item>
  /// <item><description>Consider the constrained space of context menus</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The menu can contain buttons, toggle buttons, checkboxes, or nested submenus, providing rich
  /// functionality while maintaining quick access to the most common action through the primary button.
  /// </para>
  /// </remarks>
  public MenuRegular? MenuRegular { get; set; }
}