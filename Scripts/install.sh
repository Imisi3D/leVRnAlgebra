#! /bin/sh

UNITY_DOWNLOAD_CACHE="$(pwd)/unity_download_cache"
UNITY_OSX_PACKAGE_URL="https://download.unity3d.com/download_unity/3e18427e571f/MacEditorInstaller/Unity.pkg"

# Download Unity3D installer into the container
# Downloads a file if it does not exist
download() {

	URL=$1
	FILE=`basename "$URL"`
	
	# Downloads a package if it does not already exist in cache
	if [ ! -e $UNITY_DOWNLOAD_CACHE/`basename "$URL"` ] ; then
		echo "$FILE does not exist. Downloading from $URL: "
		mkdir -p "$UNITY_DOWNLOAD_CACHE"
		curl -o $UNITY_DOWNLOAD_CACHE/`basename "$URL"` "$URL"
	else
		echo "$FILE Exists. Skipping download."
	fi
}

# Downloads and installs a package from an internet URL
install() {
	PACKAGE_URL=$1
	download $1

	echo "Installing `basename "$PACKAGE_URL"`"
	sudo installer -dumplog -package $UNITY_DOWNLOAD_CACHE/`basename "$PACKAGE_URL"` -target /
}

echo "Contents of Unity Download Cache:"
ls $UNITY_DOWNLOAD_CACHE

echo "Installing Unity..."
install $UNITY_OSX_PACKAGE_URL

#  Refer to https://unity3d.com/get-unity/download/archive and find the link pointed to by Mac "Unity Editor"
#echo 'Downloading Unity 2019.1.2 pkg:'
#curl --retry 5 -o Unity.pkg https://download.unity3d.com/download_unity/3e18427e571f/MacEditorInstaller/Unity.pkg
#if [ $? -ne 0 ]; then { echo "Download failed"; exit $?; } fi

# By default, only Mac OSX support is included in the original editor package; Windows, Linux, iOS, Android, and others are separate

# We download Windows support
#echo 'Downloading Unity 2019.1.2 Windows Build Support pkg:'
#curl --retry 5 -o Unity_win.pkg https://download.unity3d.com/download_unity/3e18427e571f/MacEditorTargetInstaller/UnitySetup-Windows-Mono-Support-for-Editor-2019.1.2f1.pkg
#if [ $? -ne 0 ]; then { echo "Download failed"; exit $?; } fi

# Run installer(s)
#echo 'Installing Unity.pkg'
#sudo installer -dumplog -package Unity.pkg -target /
#echo 'Installing Unity_win.pkg'
#sudo installer -dumplog -package Unity_win.pkg -target /
