// **********************************************************************
//
// Copyright (c) 2003-2015 ZeroC, Inc. All rights reserved.
//
// **********************************************************************

public class PrinterI extends Demo._PrinterDisp
{
    public void
    printString(String s, Ice.Current current)
    {
        System.out.println(s);
    }
}