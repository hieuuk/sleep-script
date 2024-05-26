const { exec } = require('child_process');

function putWindowsToSleep() {
  exec('rundll32.exe powrprof.dll,SetSuspendState 0,1,0', (error, stdout, stderr) => {
    if (error) {
      console.error(`Error: ${error.message}`);
      return;
    }

    if (stderr) {
      console.error(`Stderr: ${stderr}`);
      return;
    }

    console.log('The system is going to sleep.');
  });
}

putWindowsToSleep();
