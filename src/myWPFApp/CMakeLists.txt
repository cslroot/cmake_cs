enable_language(CSharp)
include(CSharpUtilities)
set(PROJ_NAME_CS MyWPFApp)

add_executable(${PROJ_NAME_CS}
      App.config
      App.xaml
      App.xaml.cs
      MainWindow.xaml
      MainWindow.xaml.cs
      Properties/AssemblyInfo.cs
      Properties/Resources.Designer.cs
      Properties/Resources.resx
      Properties/Settings.Designer.cs
      Properties/Settings.settings
)

csharp_set_designer_cs_properties(
      Properties/AssemblyInfo.cs
      Properties/Resources.Designer.cs
      Properties/Resources.resx
      Properties/Settings.Designer.cs
      Properties/Settings.settings
)

csharp_set_xaml_cs_properties(
	App.xaml
	App.xaml.cs
	MainWindow.xaml
	MainWindow.xaml.cs)

target_compile_options(${PROJ_NAME_CS} PRIVATE "/langversion:latest")
# set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "net6.0")

set_property(SOURCE App.xaml PROPERTY VS_XAML_TYPE "ApplicationDefinition")
set_property(TARGET ${PROJ_NAME_CS} PROPERTY WIN32_EXECUTABLE FALSE)
set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_CONFIGURATION_TYPE Application)
# set_target_properties(${PROJ_NAME_CS} PROPERTIES LINK_FLAGS "/SUBSYSTEM:CONSOLE")
set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_DOTNET_REFERENCES
	"Microsoft.CSharp"
    "PresentationCore"
    "PresentationFramework"
	"System"
	"System.Core"
	"System.Data"
	"System.Data.DatasetExtensions"
	"System.Net.Http"
    "System.Xaml"
	"System.Xml"
	"System.Xml.Linq"
	"WindowsBase"
)

target_link_libraries(${PROJ_NAME_CS} PUBLIC MyClassLib)

