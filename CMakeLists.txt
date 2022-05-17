cmake_minimum_required(VERSION 3.20.0)
project(cmake_cs VERSION 0.1.0)

# same destinatin directory for dll
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)  # .exe, .dll with SHARED, .pdb
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)  # .dll, .so with MODULE
set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/arc)  # .lib .exp, .a with STATIC


# information
message(STATUS "CMAKE_GENERATOR: " ${CMAKE_GENERATOR})
message(STATUS "CMAKE_CXX_COMPILER_ID: " ${CMAKE_CXX_COMPILER_ID})

# for VS Generator
if("${CMAKE_GENERATOR}" MATCHES "^Visual Studio.*")
    # prevent MinSizeRel and RelWithDebInfo for vcxproj
    set(CMAKE_CONFIGURATION_TYPES "Debug;Release" CACHE STRING "limited configs" FORCE)
    # suppress ZERO_CHECK project generation
    set(CMAKE_SUPPRESS_REGENERATION true)
    # enable to filter in project
    set_property(GLOBAL PROPERTY USE_FOLDERS ON)
    set_property(GLOBAL PROPERTY CMAKE_SKIP_PACKAGE_ALL_DEPENDENCY true)
    set_property(GLOBAL PROPERTY CMAKE_SKIP_INSTALL_ALL_DEPENDENCY true)
endif()


add_subdirectory(src)
# add_subdirectory(dotnet)
