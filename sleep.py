import os

def put_windows_to_sleep():
    try:
        # Putting the system to sleep
        os.system("rundll32.exe powrprof.dll,SetSuspendState 0,1,0")
        print("The system is going to sleep.")
    except Exception as e:
        print(f"An error occurred: {e}")

if __name__ == "__main__":
    put_windows_to_sleep()