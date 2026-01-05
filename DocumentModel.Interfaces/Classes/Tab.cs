namespace DocumentModel;

/// <summary>
/// Represents a tab in the Office ribbon interface that organizes groups of related commands and controls.
/// Tabs are the top-level organizational unit in the ribbon, appearing as clickable labels across the top
/// of Office applications (e.g., Home, Insert, Design). Custom tabs allow add-ins to create dedicated
/// command surfaces that integrate seamlessly with Office's native ribbon structure.
/// </summary>
/// <remarks>
/// <para>
/// Ribbon tabs are the primary navigation mechanism in modern Office applications, organizing commands
/// into logical categories that users can switch between. Tabs provide:
/// <list type="bullet">
/// <item><description><b>Top-level organization:</b> Group related functionality into distinct, labeled sections</description></item>
/// <item><description><b>Context awareness:</b> Can appear or disappear based on document state or selection</description></item>
/// <item><description><b>Customization:</b> Add-ins can create custom tabs or modify existing Office tabs</description></item>
/// <item><description><b>Integration:</b> Custom tabs appear alongside native Office tabs (Home, Insert, etc.)</description></item>
/// </list>
/// </para>
/// <para>
/// Tabs contain one or more <see cref="Group"/> objects, which in turn contain individual controls like buttons,
/// galleries, and dropdown menus. This hierarchical structure creates a clear visual organization:
/// <code>
/// Tab (e.g., "Home")
///   ├─ Group 1 (e.g., "Clipboard")
///   │    ├─ Button: Paste
///   │    ├─ Button: Cut
///   │    └─ Button: Copy
///   ├─ Group 2 (e.g., "Font")
///   │    ├─ Gallery: Font
///   │    ├─ Dropdown: Size
///   │    └─ Buttons: Bold, Italic, Underline
///   └─ Group 3 (e.g., "Paragraph")
/// </code>
/// </para>
/// <para>
/// There are several types of tabs in Office:
/// <list type="bullet">
/// <item><description><b>Core tabs:</b> Built-in Office tabs (Home, Insert, Design, etc.) that are always available</description></item>
/// <item><description><b>Custom tabs:</b> Add-in defined tabs that provide access to custom functionality</description></item>
/// <item><description><b>Contextual tabs:</b> Tabs that appear only when specific objects are selected (e.g., Picture Tools, Table Tools)</description></item>
/// <item><description><b>Modified tabs:</b> Built-in tabs with custom groups or controls added by add-ins</description></item>
/// </list>
/// </para>
/// <para>
/// Custom tabs are essential for Office add-ins that provide substantial functionality:
/// <list type="bullet">
/// <item><description>Give add-ins prominent, discoverable placement in the ribbon</description></item>
/// <item><description>Provide dedicated space for organizing complex feature sets</description></item>
/// <item><description>Create branded experiences with custom labels and organization</description></item>
/// <item><description>Allow grouping of related commands for efficient workflows</description></item>
/// </list>
/// </para>
/// <para>
/// Tab positioning and visibility can be controlled through:
/// <list type="bullet">
/// <item><description><b>Static properties:</b> Fixed label, visibility, and positioning</description></item>
/// <item><description><b>Dynamic callbacks:</b> Runtime control of label, visibility, and keytip based on context</description></item>
/// <item><description><b>Insertion points:</b> Precise positioning relative to Office's built-in tabs or other custom tabs</description></item>
/// </list>
/// </para>
/// <para>
/// Best practices for custom tabs:
/// <list type="bullet">
/// <item><description>Use clear, concise labels (1-2 words) that describe the tab's purpose</description></item>
/// <item><description>Group related commands logically within the tab using multiple groups</description></item>
/// <item><description>Consider whether a custom tab is necessary or if adding to existing tabs is more appropriate</description></item>
/// <item><description>Use contextual visibility to show tabs only when relevant to the current context</description></item>
/// <item><description>Provide keytips for keyboard navigation (Alt + custom key)</description></item>
/// <item><description>Position custom tabs near related Office tabs for intuitive workflows</description></item>
/// </list>
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a simple custom tab
/// var customTab = new Tab
/// {
///     Id = "myAddInTab",
///     Label = "My Add-In",
///     Keytip = "M",
///     Group = new Group
///     {
///         Id = "mainGroup",
///         Label = "Main Tools"
///         // Contains buttons, galleries, etc.
///     }
/// };
/// 
/// // Create a custom tab positioned after the Home tab
/// var positionedTab = new Tab
/// {
///     Id = "customTools",
///     Label = "Custom Tools",
///     InsertAfterMso = "TabHome",
///     Keytip = "C",
///     Group = new Group
///     {
///         Id = "toolsGroup",
///         Label = "Tools"
///     }
/// };
/// 
/// // Create a contextual tab with dynamic visibility
/// var contextualTab = new Tab
/// {
///     Id = "imageTools",
///     Label = "Image Tools",
///     GetVisible = "IsImageSelected",
///     Keytip = "I",
///     Group = new Group
///     {
///         Id = "imageGroup",
///         Label = "Edit"
///     }
/// };
/// 
/// // Modify a built-in Office tab by adding a custom group
/// var modifiedTab = new Tab
/// {
///     IdMso = "TabHome",
///     Group = new Group
///     {
///         Id = "customHomeGroup",
///         Label = "My Commands",
///         InsertAfterMso = "GroupClipboard"
///     }
/// };
/// </code>
/// </example>
public interface Tab :
{
  /// <summary>
  /// Gets or sets the unique identifier for this custom tab.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The ID is used to uniquely identify this tab for:
  /// <list type="bullet">
  /// <item><description>Referencing in callback functions and code-behind</description></item>
  /// <item><description>Programmatic ribbon invalidation and updates</description></item>
  /// <item><description>Positioning other tabs or groups relative to this tab</description></item>
  /// <item><description>Debugging and maintaining ribbon customizations</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The ID should be unique across all custom tabs in your add-in and should be descriptive
  /// of the tab's purpose (e.g., "customDataTab", "myAddInHomeTab", "reportingTab").
  /// Use consistent naming conventions across your ribbon customization for maintainability.
  /// </para>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  /// Gets or sets the namespace-qualified identifier for this tab.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The qualified ID allows tabs to be organized into namespaces, preventing naming conflicts
  /// when multiple add-ins customize the ribbon. The format is typically "namespace:localId"
  /// where namespace identifies the add-in, company, or feature area.
  /// </para>
  /// <para>
  /// Qualified IDs are particularly important when:
  /// <list type="bullet">
  /// <item><description>Multiple add-ins from different vendors extend the same Office application</description></item>
  /// <item><description>Creating suites of related add-ins that need coordinated ribbon customization</description></item>
  /// <item><description>Avoiding ID collisions in complex enterprise deployments</description></item>
  /// <item><description>Positioning tabs relative to other add-ins' custom tabs</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Example: "MyCompany.CRM:customerTab" clearly identifies the tab's ownership and purpose.
  /// </para>
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  /// Gets or sets an arbitrary tag value for application-specific purposes.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The tag property provides flexible storage for custom metadata used in application logic.
  /// Unlike ID properties, tags don't need to be unique and can be shared across multiple tabs or controls.
  /// Common uses include:
  /// <list type="bullet">
  /// <item><description>Categorizing tabs by feature module or functionality area</description></item>
  /// <item><description>Storing version or compatibility information</description></item>
  /// <item><description>Flagging tabs with special handling requirements (e.g., "premium", "beta")</description></item>
  /// <item><description>Implementing license-based or role-based tab management</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Tags can be used in callback logic to implement dynamic behavior across groups of tabs,
  /// such as hiding all tabs marked with a specific tag when a feature is disabled.
  /// </para>
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  /// Gets or sets the Microsoft Office built-in tab identifier to customize or reference.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The idMso (ID Microsoft Office) property serves two purposes:
  /// <list type="bullet">
  /// <item><description><b>Customization:</b> Modify properties of a built-in Office tab (add custom groups, change visibility)</description></item>
  /// <item><description><b>Positioning reference:</b> Used with insert properties to position custom tabs relative to built-in tabs</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common built-in tab IDs include:
  /// <list type="bullet">
  /// <item><description><b>TabHome:</b> The Home tab (primary editing commands)</description></item>
  /// <item><description><b>TabInsert:</b> The Insert tab (insert objects, media, etc.)</description></item>
  /// <item><description><b>TabPageLayoutWord:</b> Page Layout tab in Word</description></item>
  /// <item><description><b>TabReferences:</b> References tab in Word (citations, bibliography)</description></item>
  /// <item><description><b>TabReview:</b> Review tab (proofing, comments, tracking)</description></item>
  /// <item><description><b>TabView:</b> View tab (document views, zoom, windows)</description></item>
  /// <item><description><b>TabDeveloper:</b> Developer tab (macros, add-ins, XML)</description></item>
  /// </list>
  /// The available tabs vary by Office application (Word, Excel, PowerPoint, etc.).
  /// </para>
  /// <para>
  /// When customizing a built-in tab using idMso:
  /// <list type="bullet">
  /// <item><description>You can add custom groups to the tab</description></item>
  /// <item><description>You can control the tab's visibility (hide built-in tabs if needed)</description></item>
  /// <item><description>You cannot remove built-in groups or change the tab's core structure</description></item>
  /// <item><description>Custom groups are typically added at the end unless positioned explicitly</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? IdMso { get; set; }

  /// <summary>
  /// Gets or sets the display label text for the tab that appears in the ribbon.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The label is the visible text users see in the ribbon tab bar and is crucial for:
  /// <list type="bullet">
  /// <item><description>User recognition and navigation</description></item>
  /// <item><description>Communicating the tab's purpose and content</description></item>
  /// <item><description>Creating a professional, polished appearance</description></item>
  /// <item><description>Branding and product identity</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Best practices for tab labels:
  /// <list type="bullet">
  /// <item><description><b>Keep it short:</b> 1-2 words maximum (e.g., "Home", "Insert", "Data Analysis")</description></item>
  /// <item><description><b>Use title case:</b> Capitalize the first letter of each word</description></item>
  /// <item><description><b>Be descriptive:</b> Clearly indicate what commands or features the tab contains</description></item>
  /// <item><description><b>Avoid acronyms:</b> Unless they're widely recognized in your domain</description></item>
  /// <item><description><b>Match Office style:</b> Follow Office's labeling conventions for consistency</description></item>
  /// <item><description><b>Consider localization:</b> Labels should be translatable for international users</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Examples of effective tab labels:
  /// <list type="bullet">
  /// <item><description>"My Add-In" - Clear branding for simple add-ins</description></item>
  /// <item><description>"CRM Tools" - Describes functionality category</description></item>
  /// <item><description>"Reports" - Direct and concise</description></item>
  /// <item><description>"Data Import" - Specific task-oriented</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? Label { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically provides the tab's label text.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getLabel callback enables dynamic tab labels that adapt to:
  /// <list type="bullet">
  /// <item><description>User language or locale (localized tab names)</description></item>
  /// <item><description>Application state or mode (e.g., "Design Mode", "Edit Mode")</description></item>
  /// <item><description>User role or permissions (e.g., "Admin Tools", "User Tools")</description></item>
  /// <item><description>License or feature availability (e.g., "Premium Features", "Basic Features")</description></item>
  /// <item><description>Document type or context (e.g., "Invoice Tools" vs "Report Tools")</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a ribbon control parameter and should return a string value.
  /// Office calls this function when the ribbon is loaded and when the ribbon is invalidated programmatically.
  /// </para>
  /// <para>
  /// Dynamic labels are particularly useful for:
  /// <list type="bullet">
  /// <item><description>Multi-language add-ins that need runtime localization</description></item>
  /// <item><description>Context-aware tabs that change purpose based on selection or mode</description></item>
  /// <item><description>Tabs that display status or state information in their label</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Gets or sets the ID of a built-in Office tab after which this custom tab should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertAfterMso property allows precise positioning of custom tabs within the ribbon
  /// by placing them immediately after built-in Office tabs. This is essential for:
  /// <list type="bullet">
  /// <item><description>Creating logical workflow by placing custom tabs near related Office tabs</description></item>
  /// <item><description>Maintaining intuitive navigation (e.g., data import tab after Data tab)</description></item>
  /// <item><description>Ensuring custom tabs appear in predictable, consistent locations</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common positioning strategies:
  /// <list type="bullet">
  /// <item><description><b>After Home:</b> For general-purpose add-in tabs (insertAfterMso="TabHome")</description></item>
  /// <item><description><b>After Insert:</b> For tabs that add content or objects (insertAfterMso="TabInsert")</description></item>
  /// <item><description><b>Before View:</b> For analysis or data tabs (use insertBeforeMso="TabView")</description></item>
  /// <item><description><b>At end:</b> Don't specify positioning to place at the end of the tab bar</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// For example, setting insertAfterMso="TabHome" places the custom tab immediately after
  /// the built-in Home tab, making it the second tab in the ribbon (in most cases).
  /// </para>
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  /// Gets or sets the ID of a built-in Office tab before which this custom tab should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertBeforeMso property allows precise positioning of custom tabs by placing them
  /// immediately before built-in Office tabs. This is useful when you want custom functionality
  /// to appear earlier in the tab sequence or when the logical flow requires placement before
  /// a specific Office tab.
  /// </para>
  /// <para>
  /// For example, setting insertBeforeMso="TabView" places the custom tab immediately before
  /// the built-in View tab, ensuring it appears near the end of the tab bar but before view-related commands.
  /// </para>
  /// <para>
  /// Consider using insertBeforeMso when:
  /// <list type="bullet">
  /// <item><description>Your custom tab provides functionality that should precede a specific Office tab</description></item>
  /// <item><description>You want to ensure consistent positioning even if Office adds new tabs</description></item>
  /// <item><description>Creating a logical workflow where your tab's content leads into an Office tab's features</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  /// Gets or sets the qualified ID of a custom tab after which this tab should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertAfterQualifiedId property enables positioning relative to other custom tabs
  /// (rather than built-in Office tabs). This is important when:
  /// <list type="bullet">
  /// <item><description>Multiple add-ins need to coordinate their ribbon layout</description></item>
  /// <item><description>Creating suites of related add-ins with a specific tab order</description></item>
  /// <item><description>Building add-in dependencies where one add-in's tabs should follow another's</description></item>
  /// <item><description>Enterprise deployments with multiple custom tabs that need consistent ordering</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// For example, if you have multiple related add-ins from your company, you might position
  /// them relative to each other: "MyCompany.CRM:mainTab" followed by "MyCompany.Reports:mainTab".
  /// </para>
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  /// Gets or sets the qualified ID of a custom tab before which this tab should be inserted.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The insertBeforeQualifiedId property enables positioning relative to other custom tabs
  /// (rather than built-in Office tabs). This allows fine-grained control over the order of
  /// custom tabs in complex scenarios with multiple add-ins.
  /// </para>
  /// <para>
  /// This is particularly useful in enterprise environments where:
  /// <list type="bullet">
  /// <item><description>Multiple department-specific add-ins need coordinated placement</description></item>
  /// <item><description>Add-in loading order may vary but tab order should remain consistent</description></item>
  /// <item><description>Creating dependencies between add-ins where tab order matters</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }

  /// <summary>
  /// Gets or sets whether the tab is visible in the ribbon.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Tab visibility control allows tabs to appear or disappear based on:
  /// <list type="bullet">
  /// <item><description>Document type or format (show only for specific file types)</description></item>
  /// <item><description>User permissions or license level (hide premium features for basic users)</description></item>
  /// <item><description>Application state or mode (show design tab only in design mode)</description></item>
  /// <item><description>Feature availability or configuration (hide disabled features)</description></item>
  /// <item><description>Selection context (show contextual tabs only when relevant objects are selected)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Hidden tabs:
  /// <list type="bullet">
  /// <item><description>Do not appear in the ribbon tab bar</description></item>
  /// <item><description>Cannot be accessed via keyboard shortcuts or navigation</description></item>
  /// <item><description>Do not occupy space or affect the layout of other tabs</description></item>
  /// <item><description>Can be dynamically shown/hidden through ribbon invalidation</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Use visibility thoughtfully:
  /// <list type="bullet">
  /// <item><description>Don't hide tabs unnecessarily - users expect consistency</description></item>
  /// <item><description>Provide clear ways to enable hidden features (settings, license upgrade)</description></item>
  /// <item><description>Consider disabling groups/buttons instead of hiding entire tabs when possible</description></item>
  /// <item><description>Use contextual tabs (appear/disappear with selection) for selection-specific commands</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public bool? Visible { get; set; }

  /// <summary>
  /// Gets or sets the name of the callback function that dynamically determines whether the tab is visible.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The getVisible callback enables dynamic tab visibility based on runtime conditions such as:
  /// <list type="bullet">
  /// <item><description><b>Document context:</b> Show tabs only for specific document types (Excel workbooks vs Word documents)</description></item>
  /// <item><description><b>Selection state:</b> Display contextual tabs when specific objects are selected (images, charts, tables)</description></item>
  /// <item><description><b>User authentication:</b> Show admin tabs only for administrators</description></item>
  /// <item><description><b>Feature flags:</b> Display beta feature tabs only when enabled</description></item>
  /// <item><description><b>License status:</b> Show premium tabs only for licensed users</description></item>
  /// <item><description><b>Application mode:</b> Display different tabs for edit mode vs read-only mode</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a ribbon control parameter and should return a boolean value.
  /// Office calls this function when the ribbon loads and whenever the ribbon is invalidated programmatically
  /// (e.g., when selection changes, document opens, or user logs in).
  /// </para>
  /// <para>
  /// Dynamic visibility is essential for:
  /// <list type="bullet">
  /// <item><description><b>Contextual tabs:</b> Like Office's Picture Tools or Table Tools that appear with selection</description></item>
  /// <item><description><b>Adaptive interfaces:</b> Ribbons that adapt to user skill level or role</description></item>
  /// <item><description><b>Clean UI:</b> Hiding irrelevant tabs to reduce clutter and cognitive load</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Gets or sets the keyboard shortcut (keytip) that activates this tab.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Keytips appear when users press the Alt key, displaying keyboard shortcuts for ribbon tabs and controls.
  /// For tabs, keytips enable quick keyboard navigation and are essential for:
  /// <list type="bullet">
  /// <item><description>Accessibility compliance (keyboard-only users)</description></item>
  /// <item><description>Power user efficiency (faster than mouse navigation)</description></item>
  /// <item><description>Consistency with Office's keyboard navigation model</description></item>
  /// <item><description>Supporting users with motor disabilities or preferences</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Keytip guidelines for tabs:
  /// <list type="bullet">
  /// <item><description><b>Length:</b> Typically 1 character, occasionally 2 for uniqueness</description></item>
  /// <item><description><b>Mnemonic:</b> Use the first letter of the tab label when possible (e.g., "H" for Home, "I" for Insert)</description></item>
  /// <item><description><b>Uniqueness:</b> Must be unique within the entire ribbon (don't conflict with Office's built-in keytips)</description></item>
  /// <item><description><b>Memorable:</b> Choose intuitive letters related to the tab's purpose</description></item>
  /// <item><description><b>Consistency:</b> Use the same keytip if your add-in appears in multiple Office apps</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Office's built-in keytips to avoid conflicts with:
  /// <list type="bullet">
  /// <item><description>H = Home, I = Insert, N = Design (varies by app), P = Page Layout, S = References (Word)</description></item>
  /// <item><description>M = Mailings (Word), A = Data (Excel), R = Review, W = View</description></item>
  /// <item><description>Y = Developer (if enabled), Numbers 1-9 often used for tabs</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If keytip conflicts exist, Office will modify the keytip display (showing two-character sequences),
  /// but it's better to avoid conflicts through careful selection.
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
  /// <item><description>User language or locale (different mnemonic letters for localized tab names)</description></item>
  /// <item><description>Keytip conflicts with other add-ins or Office tabs</description></item>
  /// <item><description>Application mode or state (different shortcuts for different modes)</description></item>
  /// <item><description>User preferences (customizable keyboard shortcuts)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The callback function receives a ribbon control parameter and should return a string value.
  /// </para>
  /// <para>
  /// Dynamic keytips are most commonly used for:
  /// <list type="bullet">
  /// <item><description><b>Localization:</b> Providing appropriate mnemonic keytips for different languages</description></item>
  /// <item><description><b>Conflict resolution:</b> Adjusting keytips when conflicts with other add-ins are detected</description></item>
  /// <item><description><b>Context awareness:</b> Different keytips for tabs with dynamic labels</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Gets or sets the group or collection of groups contained within this tab.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Groups are the organizational units within a tab that contain individual controls (buttons, galleries,
  /// dropdowns, etc.). Each tab typically contains multiple groups, each focused on a related set of commands:
  /// <list type="bullet">
  /// <item><description><b>Visual organization:</b> Groups have labels and visual separators that make the ribbon scannable</description></item>
  /// <item><description><b>Logical grouping:</b> Related commands are grouped together (e.g., Clipboard, Font, Paragraph)</description></item>
  /// <item><description><b>Responsive layout:</b> Groups collapse or resize based on available ribbon width</description></item>
  /// <item><description><b>Dialog launchers:</b> Groups can have dialog launcher buttons for advanced options</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// A tab can contain multiple groups, and groups should be organized by:
  /// <list type="bullet">
  /// <item><description><b>Workflow:</b> Arrange groups in the order users typically work (left to right)</description></item>
  /// <item><description><b>Frequency:</b> Place most-used groups on the left for easy access</description></item>
  /// <item><description><b>Relationship:</b> Keep related functionality together in the same group</description></item>
  /// <item><description><b>Size balance:</b> Distribute controls across groups for even visual weight</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Best practices for groups within tabs:
  /// <list type="bullet">
  /// <item><description>Aim for 3-6 groups per tab for optimal balance</description></item>
  /// <item><description>Each group should have a clear, concise label</description></item>
  /// <item><description>Avoid overly large groups (5-8 controls maximum per group typically)</description></item>
  /// <item><description>Consider how groups will collapse on smaller screens</description></item>
  /// <item><description>Use dialog launchers for advanced settings rather than cluttering groups</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The Group property represents either a single group or the first group in a collection.
  /// To add multiple groups to a tab, you typically define them in sequence in the ribbon XML
  /// or through the extensibility API. Each group can contain various control types including
  /// buttons, split buttons, galleries, dropdown menus, and more.
  /// </para>
  /// </remarks>
  public Group? Group { get; set; }
}