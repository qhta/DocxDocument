namespace DocumentModel;

/// <summary>
/// Represents a customizable context menu (right-click menu) in Office applications.
/// Context menus provide quick access to frequently used commands relevant to the current selection
/// or context, appearing when users right-click on document elements such as text, tables, images, or other objects.
/// </summary>
/// <remarks>
/// <para>
/// Context menus in Office applications are part of the ribbon extensibility framework, allowing developers
/// to customize the menus that appear when users right-click in different contexts. This interface enables:
/// <list type="bullet">
/// <item><description><b>Menu customization:</b> Add custom commands to built-in context menus</description></item>
/// <item><description><b>Context-aware commands:</b> Present relevant options based on what the user clicked</description></item>
/// <item><description><b>UI consistency:</b> Integrate custom commands with Office's native UI design</description></item>
/// <item><description><b>Workflow efficiency:</b> Provide quick access to custom functionality</description></item>
/// </list>
/// </para>
/// <para>
/// Context menus can contain various control types:
/// <list type="bullet">
/// <item><description><b>Buttons:</b> Execute immediate actions (copy, paste, format)</description></item>
/// <item><description><b>Toggle buttons:</b> Switch settings on/off (bold, italic)</description></item>
/// <item><description><b>Checkboxes:</b> Enable/disable options with visible state</description></item>
/// <item><description><b>Galleries:</b> Display visual choices (styles, colors, shapes)</description></item>
/// <item><description><b>Split buttons:</b> Combine default action with dropdown options</description></item>
/// <item><description><b>Submenus:</b> Organize related commands in nested menus</description></item>
/// <item><description><b>Dynamic menus:</b> Populate menu items at runtime</description></item>
/// <item><description><b>Separators:</b> Visually group related commands</description></item>
/// </list>
/// </para>
/// <para>
/// Context menus are identified by unique IDs (idMso) that correspond to specific contexts in Office:
/// <list type="bullet">
/// <item><description><b>ContextMenuText:</b> Appears when right-clicking on text</description></item>
/// <item><description><b>ContextMenuTable:</b> Appears when right-clicking in a table</description></item>
/// <item><description><b>ContextMenuImage:</b> Appears when right-clicking on an image</description></item>
/// <item><description><b>ContextMenuShape:</b> Appears when right-clicking on a shape</description></item>
/// <item><description><b>ContextMenuCell:</b> Appears when right-clicking on a table cell</description></item>
/// </list>
/// The specific contexts available depend on the Office application (Word, Excel, PowerPoint).
/// </para>
/// <para>
/// This interface is part of the Office ribbon extensibility model introduced in Office 2007
/// and enhanced in Office 2010 and later versions. Context menu customization requires
/// appropriate ribbon XML definitions and callback implementations in the host application.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Define a custom context menu for text with a custom command
/// var textContextMenu = new ContextMenu
/// {
///     IdMso = "ContextMenuText",
///     ButtonRegular = new ButtonRegular
///     {
///         Id = "customFormatButton",
///         Label = "Apply Custom Format",
///         ImageMso = "FormatPainter",
///         // OnAction callback would be defined in the add-in
///     }
/// };
/// 
/// // Add a submenu to a context menu
/// var tableContextMenu = new ContextMenu
/// {
///     IdMso = "ContextMenuTable",
///     MenuRegular = new MenuRegular
///     {
///         Id = "customTableMenu",
///         Label = "Custom Table Tools",
///         // Nested menu items would be added here
///     }
/// };
/// 
/// // Add a separator and toggle button
/// var imageContextMenu = new ContextMenu
/// {
///     IdMso = "ContextMenuImage",
///     MenuSeparatorNoTitle = new MenuSeparatorNoTitle(),
///     ToggleButtonRegular = new ToggleButtonRegular
///     {
///         Id = "lockAspectRatio",
///         Label = "Lock Aspect Ratio",
///         // GetPressed callback determines current state
///     }
/// };
/// </code>
/// </example>
public interface ContextMenu : IModelElement
{
  /// <summary>
  /// Gets or sets the Microsoft Office built-in context menu identifier that this customization applies to.
  /// </summary>
  /// <value>
  /// A string containing the Office-defined context menu ID (e.g., "ContextMenuText", "ContextMenuTable").
  /// If <see langword="null"/>, the context menu customization is not associated with a specific built-in menu.
  /// </value>
  /// <remarks>
  /// <para>
  /// The idMso (ID Microsoft Office) property identifies which built-in context menu should be customized.
  /// This allows add-ins to inject custom controls into existing Office context menus that appear in
  /// specific situations. Common context menu IDs include:
  /// </para>
  /// <para>
  /// <b>Word context menu IDs:</b>
  /// <list type="bullet">
  /// <item><description><b>ContextMenuText:</b> Right-click on regular text</description></item>
  /// <item><description><b>ContextMenuTextTable:</b> Right-click inside a table</description></item>
  /// <item><description><b>ContextMenuTable:</b> Right-click on a table structure</description></item>
  /// <item><description><b>ContextMenuImage:</b> Right-click on an image</description></item>
  /// <item><description><b>ContextMenuTextInTable:</b> Right-click on text within a table cell</description></item>
  /// <item><description><b>ContextMenuDrawing:</b> Right-click on a drawing object</description></item>
  /// <item><description><b>ContextMenuHeaderFooter:</b> Right-click in header/footer area</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// <b>Excel context menu IDs:</b>
  /// <list type="bullet">
  /// <item><description><b>ContextMenuCell:</b> Right-click on a cell</description></item>
  /// <item><description><b>ContextMenuRowColumnHeader:</b> Right-click on row/column headers</description></item>
  /// <item><description><b>ContextMenuChart:</b> Right-click on a chart</description></item>
  /// <item><description><b>ContextMenuPivotTable:</b> Right-click on a PivotTable</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// <b>PowerPoint context menu IDs:</b>
  /// <list type="bullet">
  /// <item><description><b>ContextMenuText:</b> Right-click on text</description></item>
  /// <item><description><b>ContextMenuShape:</b> Right-click on a shape</description></item>
  /// <item><description><b>ContextMenuSlide:</b> Right-click on a slide thumbnail</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// This property is only available in Office 2010 and later versions. Add-ins targeting Office 2010+
  /// can use this to ensure context menu customizations appear in the appropriate contexts.
  /// The exact list of available context menu IDs is documented in the Office ribbon extensibility documentation.
  /// </para>
  /// <para>
  /// To find available context menu IDs, developers can use the Office Fluent UI Control Identifiers
  /// documentation or inspect existing Office UI using tools like the Custom UI Editor.
  /// </para>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  /// Gets or sets a reference to a built-in Office control to clone and add to the context menu.
  /// </summary>
  /// <value>
  /// A <see cref="ControlCloneRegular"/> object that specifies which built-in Office control to duplicate.
  /// If <see langword="null"/>, no built-in control is cloned.
  /// </value>
  /// <remarks>
  /// <para>
  /// Control cloning allows add-ins to duplicate existing Office commands and place them in custom
  /// context menus. This is useful when you want to provide quick access to a built-in Office feature
  /// that isn't normally available in a particular context menu. For example, you might clone the
  /// "Format Painter" button and add it to the text context menu.
  /// </para>
  /// <para>
  /// Cloned controls maintain their original behavior, icons, tooltips, and keyboard shortcuts.
  /// This ensures consistency with the native Office experience while providing enhanced accessibility
  /// to frequently used commands.
  /// </para>
  /// </remarks>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

  /// <summary>
  /// Gets or sets a custom button control to add to the context menu.
  /// </summary>
  /// <value>
  /// A <see cref="ButtonRegular"/> object defining the button's appearance and behavior.
  /// If <see langword="null"/>, no button is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Buttons are the most common control type in context menus, used for immediate actions that
  /// execute when clicked. Context menu buttons typically:
  /// <list type="bullet">
  /// <item><description>Perform a single, well-defined action (copy, paste, format, insert)</description></item>
  /// <item><description>Display an icon and label for easy identification</description></item>
  /// <item><description>Execute callback functions in the host add-in</description></item>
  /// <item><description>Can be dynamically enabled/disabled based on context</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Custom buttons integrate seamlessly with Office's native context menu styling and behavior,
  /// including hover effects, keyboard navigation, and accessibility features.
  /// </para>
  /// </remarks>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  /// Gets or sets a checkbox control to add to the context menu.
  /// </summary>
  /// <value>
  /// An <see cref="ICheckBox"/> object defining the checkbox's appearance and behavior.
  /// If <see langword="null"/>, no checkbox is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Checkboxes in context menus provide a visual indication of on/off state for settings or options.
  /// Unlike toggle buttons, checkboxes explicitly show a checkmark when enabled, making the current
  /// state more obvious to users. Common uses include:
  /// <list type="bullet">
  /// <item><description>Enabling/disabling features or filters</description></item>
  /// <item><description>Toggling display options (show/hide elements)</description></item>
  /// <item><description>Setting boolean preferences</description></item>
  /// <item><description>Selecting options in a list of choices</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The checkbox state is typically determined by a callback function that queries the current
  /// state of the associated feature or setting.
  /// </para>
  /// </remarks>
  public ICheckBox? CheckBox { get; set; }

  /// <summary>
  /// Gets or sets a gallery control to add to the context menu.
  /// </summary>
  /// <value>
  /// A <see cref="GalleryRegular"/> object defining the gallery's appearance, items, and behavior.
  /// If <see langword="null"/>, no gallery is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Galleries in context menus display a visual collection of options that users can choose from,
  /// similar to the style galleries in Word or theme galleries in PowerPoint. Context menu galleries:
  /// <list type="bullet">
  /// <item><description>Display preview images or formatted examples of options</description></item>
  /// <item><description>Support live preview (hovering shows effect without applying)</description></item>
  /// <item><description>Can be dynamically populated based on context</description></item>
  /// <item><description>Organize related choices in a visually appealing grid layout</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Examples of gallery usage in context menus include:
  /// <list type="bullet">
  /// <item><description>Table styles or cell formatting options</description></item>
  /// <item><description>Color pickers or theme color selections</description></item>
  /// <item><description>Font or paragraph style choices</description></item>
  /// <item><description>Shape or icon selections</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Galleries provide a rich, visual user experience that can significantly improve discoverability
  /// and usability of formatting and styling options.
  /// </para>
  /// </remarks>
  public GalleryRegular? GalleryRegular { get; set; }

  /// <summary>
  /// Gets or sets a toggle button control to add to the context menu.
  /// </summary>
  /// <value>
  /// A <see cref="ToggleButtonRegular"/> object defining the toggle button's appearance and behavior.
  /// If <see langword="null"/>, no toggle button is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Toggle buttons in context menus provide a way to switch features or formatting on and off.
  /// The button's appearance changes to indicate its current state (pressed/unpressed). Common uses:
  /// <list type="bullet">
  /// <item><description>Text formatting options (Bold, Italic, Underline)</description></item>
  /// <item><description>View options (Show/Hide Gridlines, Show Formatting Marks)</description></item>
  /// <item><description>Feature toggles (Enable/Disable Auto-format)</description></item>
  /// <item><description>Lock/Unlock settings (Protect Document, Lock Aspect Ratio)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Toggle buttons visually highlight when pressed, providing immediate feedback about the current
  /// state. The pressed state is typically determined by a callback function that checks the
  /// current state of the associated feature.
  /// </para>
  /// </remarks>
  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  /// <summary>
  /// Gets or sets a split button control to add to the context menu.
  /// </summary>
  /// <value>
  /// A <see cref="SplitButtonRegular"/> object defining the split button's appearance and behavior.
  /// If <see langword="null"/>, no split button is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Split buttons combine a primary action button with a dropdown menu of related options.
  /// Clicking the main button executes a default action, while clicking the dropdown arrow
  /// reveals additional choices. This control type is useful for:
  /// <list type="bullet">
  /// <item><description>Commands with multiple variations (Paste, Paste Special, Paste Values)</description></item>
  /// <item><description>Recent or favorite items with a default choice (Insert Recent Item)</description></item>
  /// <item><description>Format commands with options (Apply Style with style variations)</description></item>
  /// <item><description>Actions with parameters (Export as PDF/XPS/Image)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Split buttons provide both quick access to the most common action and discoverability
  /// of related options, improving workflow efficiency while maintaining a clean UI.
  /// </para>
  /// </remarks>
  public SplitButtonRegular? SplitButtonRegular { get; set; }

  /// <summary>
  /// Gets or sets a submenu control to add to the context menu.
  /// </summary>
  /// <value>
  /// A <see cref="MenuRegular"/> object defining the submenu's label and nested items.
  /// If <see langword="null"/>, no submenu is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Submenus organize related commands in a hierarchical structure, helping to keep context menus
  /// uncluttered while providing access to a large number of commands. Submenus are indicated by
  /// an arrow icon and expand to show their contents when hovered or clicked. Common patterns:
  /// <list type="bullet">
  /// <item><description>Grouping related formatting options (Font submenu, Paragraph submenu)</description></item>
  /// <item><description>Organizing tool categories (Insert submenu, Convert submenu)</description></item>
  /// <item><description>Displaying recent items or history (Recent Documents, Undo History)</description></item>
  /// <item><description>Advanced or less-frequently-used options</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Submenus can contain any type of control including buttons, toggle buttons, checkboxes,
  /// and even nested submenus (though deep nesting should be avoided for usability).
  /// </para>
  /// </remarks>
  public MenuRegular? MenuRegular { get; set; }

  /// <summary>
  /// Gets or sets a dynamic submenu control that populates its items at runtime.
  /// </summary>
  /// <value>
  /// A <see cref="DynamicMenuRegular"/> object defining the dynamic submenu's behavior.
  /// If <see langword="null"/>, no dynamic submenu is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Dynamic menus generate their menu items programmatically when the menu is opened, rather than
  /// defining items statically in the ribbon XML. This is essential for scenarios where:
  /// <list type="bullet">
  /// <item><description>Menu items depend on document content (list of bookmarks, styles, or named ranges)</description></item>
  /// <item><description>Items come from external sources (database queries, web services, file system)</description></item>
  /// <item><description>The number or type of items changes frequently</description></item>
  /// <item><description>Items are context-dependent (different options based on selection)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Dynamic menus use callback functions to build the menu content on-demand:
  /// <list type="bullet">
  /// <item><description><b>getContent:</b> Returns XML defining the menu items to display</description></item>
  /// <item><description><b>invalidateContent:</b> Signals that the menu should refresh its items</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Examples of dynamic menu usage:
  /// <list type="bullet">
  /// <item><description>List of document sections, chapters, or headings for navigation</description></item>
  /// <item><description>Recently used files, items, or actions</description></item>
  /// <item><description>Available templates, macros, or custom commands</description></item>
  /// <item><description>Filtered or searched results based on user input</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public DynamicMenuRegular? DynamicMenuRegular { get; set; }

  /// <summary>
  /// Gets or sets a menu separator to visually group related commands in the context menu.
  /// </summary>
  /// <value>
  /// A <see cref="MenuSeparatorNoTitle"/> object representing a horizontal dividing line.
  /// If <see langword="null"/>, no separator is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Menu separators are horizontal lines that divide context menu items into logical groups,
  /// improving readability and organization. Best practices for using separators:
  /// <list type="bullet">
  /// <item><description>Group related commands together (all formatting options, all navigation commands)</description></item>
  /// <item><description>Separate custom commands from built-in Office commands</description></item>
  /// <item><description>Divide primary actions from secondary or destructive actions</description></item>
  /// <item><description>Use sparingly to avoid cluttering the menu with too many visual breaks</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// This property represents a separator without a title (no text label). For separators with
  /// section titles, other separator types may be available depending on the Office extensibility model.
  /// </para>
  /// <para>
  /// Well-placed separators significantly improve context menu usability by helping users quickly
  /// scan and locate the commands they need.
  /// </para>
  /// </remarks>
  public MenuSeparatorNoTitle? MenuSeparatorNoTitle { get; set; }
}