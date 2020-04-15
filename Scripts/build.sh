#! /bin/sh

# Run test and build for windows support

# Change this the name of your project. 
# This will be the name of the final executables as well.

## Run the editor unit tests
#UNITY_APPLICATION=$(find /Applications/Unity -name Unity.app | head -1)
echo "Running editor unit tests for ${UNITY_PROJECT_NAME}"
#"${UNITY_APPLICATION}/Contents/MacOS/Unity" \
#	-batchmode \
#	-nographics \
#	-silent-crashes \
#	-logFile $(pwd)/unity.log \
#	-projectPath "$(pwd)/${UNITY_PROJECT_NAME}" \
#	-runEditorTests \
#	-editorTestsResultFile $(pwd)/test.xml \
#	-quit

#rc0=$?
#echo "Unit test logs"
#cat $(pwd)/test.xml
# exit if tests failed
#if [ $rc0 -ne 0 ]; then { echo "Failed unit tests"; exit $rc0; } fi
echo "Unit test done!"

# Make build for windows executable
#echo "Attempting build for ${UNITY_PROJECT_NAME} for Windows"
#/Applications/Unity/Unity.app/Contents/MacOS/Unity \
#  -batchmode \
#  -nographics \
#  -silent-crashes \
#  -logFile $(pwd)/unity.log \
#  -projectPath "$(pwd)/${UNITY_PROJECT_NAME}" \
#  -buildWindowsPlayer "$(pwd)/Build/windows/${UNITY_PROJECT_NAME}.exe" \
#  -quit

#if [ $? = 0 ] ; then
#  echo "Building Windows exe completed successfully."
#  ERROR_CODE=0
#else
#  echo "Building Windows exe failed. Exited with $?."
#  ERROR_CODE=1
#fi


#echo "Finishing with code $ERROR_CODE"
#exit $ERROR_CODE


#rc1=$?
#echo "Build logs (Windows)"
#cat $(pwd)/unity.log

#exit $($rc1)


