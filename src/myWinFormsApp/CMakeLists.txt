enable_language(CSharp)
include(CSharpUtilities)
set(PROJ_NAME_CS MyWinFormsApp)

add_executable(${PROJ_NAME_CS}
      App.config
      Form1.cs
      Form1.Designer.cs
      Program.cs
      Properties/AssemblyInfo.cs
      Properties/Resources.Designer.cs
      Properties/Resources.resx
      Properties/Settings.Designer.cs
      Properties/Settings.settings
)

# csharp_set_designer_cs_properties(
#       Properties/AssemblyInfo.cs
#       Properties/Resources.Designer.cs
#       Properties/Resources.resx
#       Properties/Settings.Designer.cs
#       Properties/Settings.settings
# )

csharp_set_windows_forms_properties(
    Form1.cs
    Form1.Designer.cs
    Form1.resx
    Program.cs
    Properties/AssemblyInfo.cs
    Properties/Resources.Designer.cs
    Properties/Resources.resx
    Properties/Settings.Designer.cs
    Properties/Settings.settings
)


target_compile_options(${PROJ_NAME_CS} PRIVATE "/langversion:latest")
# set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "net6.0")

set_property(TARGET ${PROJ_NAME_CS} PROPERTY WIN32_EXECUTABLE FALSE)
set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_CONFIGURATION_TYPE Application)
# set_target_properties(${PROJ_NAME_CS} PROPERTIES LINK_FLAGS "/SUBSYSTEM:CONSOLE")
set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_DOTNET_REFERENCES
	"Microsoft.CSharp"
	"System"
	"System.Core"
	"System.Data"
	"System.Data.DatasetExtensions"
    "System.Deployment"
    "System.Drawing"
	"System.Net.Http"
    "System.Windows.Forms"
	"System.Xml"
	"System.Xml.Linq"
)

target_link_libraries(${PROJ_NAME_CS} PUBLIC MyClassLib)

