char[][] board=
[['1','2','.','.','3','.','.','.','.'],
 ['4','.','.','5','.','.','.','.','.'],
 ['.','9','1','.','.','.','.','.','3'],
 ['5','.','.','.','6','.','.','.','4'],
 ['.','.','.','8','.','3','.','.','5'],
 ['7','.','.','.','2','.','.','.','6'],
 ['.','.','.','.','.','.','2','.','.'],
 ['.','.','.','4','1','9','.','.','8'],
 ['.','.','.','.','8','.','.','7','9']];
bool output = IsValidSudoku(board);
Console.Write(output);


bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows= new HashSet<char>[9];
        HashSet<char>[] columns= new HashSet<char>[9];
        HashSet<char>[] boxes= new HashSet<char>[9];

        for(int i=0; i<boxes.Length;i++)
        {
            boxes[i] = new HashSet<char>();
        }
        // for(int i=0; i<9; i++)
        // {
        //     Console.WriteLine((i/3)*3);
        // }
        

        for(int i=0; i<board.Length ; i++)
        {
            rows[i]= new HashSet<char>();
            for(int j=0; j<board.Length;j++)
            {
                if(columns[j] ==null)
                    columns[j] = new HashSet<char>();
                char temp = board[i][j];
                int boxid = 3 * (i/3) + j/3;

                if(temp == '.')
                    continue;

                if(rows[i].Contains(temp) || columns[j].Contains(temp) || boxes[boxid].Contains(temp))
                {
                    return false;
                }
                rows[i].Add(temp);
                columns[j].Add(temp);
                boxes[boxid].Add(temp);
            }
        }
        return true;
}