using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    public static Stack<ICommand> UndoStack = new Stack<ICommand>();
    
    public static void ExecuteCommand(ICommand command)
    {
        command.Execute();
        UndoStack.Push(command);
    }
    
    public static void UndoCommand()
    {
        if (UndoStack.Count > 0)
        {
            ICommand activeCommand = UndoStack.Pop();
            activeCommand.Undo();
        }
    }
    
}
