class sudokuSolver {
	
	static int[,] sudokuBoard = new int[9, 9] {
		{1, 0, 0, 4, 8, 9, 0, 0, 6},
		{7, 3, 0, 0, 0, 0, 0, 4, 0},
		{0, 0, 0, 0, 0, 1, 2, 9, 5},
		{0, 0, 7, 1, 2, 0, 6, 0, 0},
		{5, 0, 0, 7, 0, 3, 0, 0, 8},
		{0, 0, 6, 0, 9, 5, 7, 0, 0},
		{9, 1, 4, 6, 0, 0, 0, 0, 0},
		{0, 2, 0, 0, 0, 0, 0, 3, 7},
		{8, 0, 0, 5, 1, 2, 0, 0, 4}
	};
	
	static bool[,] tfBoard = new bool[9, 9];
	
	static bool CheckRows(int[,] board) {
		for (int i = 0; i < 9; i++) {
			bool[] seen = new bool[9]; // Track numbers 1-9
			
			for (int j = 0; j < 9; j++) {
				int num = board[i, j];
				if (num != 0) // Ignore 0
				{
					if (seen[num - 1]) // Check for duplicates
					{
						return false;
					}
					seen[num - 1] = true; // Mark this number as seen
				}
			}
		}
		return true;
	}
	
	static bool CheckColumns(int[,] board) {
		for (int j = 0; j < 9; j++) {
        bool[] seen = new bool[9]; // Track numbers 1-9
        for (int i = 0; i < 9; i++)
        {
            int num = board[i, j];
            if (num != 0) // Ignore 0
            {
                if (seen[num - 1]) // Check for duplicates
                {
                    return false;
                }
                seen[num - 1] = true; // Mark this number as seen
				}
			}
		}
			return true;
	}
	
	static bool CheckBoxes(int[,] board) {
    for (int boxRow = 0; boxRow < 3; boxRow++)
    {
        for (int boxCol = 0; boxCol < 3; boxCol++)
        {
            bool[] seen = new bool[9]; // Track numbers 1-9
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int num = board[boxRow * 3 + i, boxCol * 3 + j];
                    if (num != 0) // Ignore 0
                    {
                        if (seen[num - 1]) // Check for duplicates
                        {
                            return false;
                        }
                        seen[num - 1] = true; // Mark this number as seen
                    }
                }
            }
        }
    }
    return true;
	}
	
	static void filltfBoard() {
		for (int i = 0; i < 9; i++) {

			for (int k = 0; k < 9; k++) {
		
				if (sudokuBoard[i, k] > 0) {
				tfBoard[i, k] = true;
				}
				else {
				tfBoard[i, k] = false;
				}
		
			}
		}
	}

	static int randomizer() {
		// Create a new instance of the Random class
        Random random = new Random();

        // Generate a random number between 1 and 9 (inclusive)
        int randomNumber = random.Next(1, 10); // 10 is exclusive
		return randomNumber;
	}
	
	static void inputRandomNums() {
		for (int i = 0; i < 9; i++) {
		
			for (int k = 0; k < 9; k++) {
			
				if (tfBoard[i, k] == false) {
					sudokuBoard[i, k] = randomizer();
				}
				else {
					continue;
				}
			}
		}	
	}
	
	static void printer (int[,] board) {
	
		for (int i = 0; i < 9; i++) {
				
			for (int k = 0; k < 9; k++) {
					
				Console.Write(board[i, k] + " ");
				
			}
			Console.WriteLine(" ");
		}
	}
	
	static void Main(string[] args) {
		
		while (true) {
			
			inputRandomNums();
			
			if (CheckColumns(sudokuBoard) && CheckRows(sudokuBoard) && CheckBoxes(sudokuBoard)) {
				break;
			}
		}
		
		printer(sudokuBoard);
		
		/*
		
		1. vælg første felt i første række og se om det er større end nul. hvis ikke så indsæt et random tal og gå til næste tal i rækken
		2. gå til næste række og fortsæt hele vejen ned
		3. check om sudokuen er rigtig løst. 
		4. hvis ikke rigtig så gentag indtil den er løst ved at force random tal gæt
		
		jeg laver en liste med true false booleans og tjekker om det er true for om det er starttal forid dem må man ikke ændre
		
		skriv random tal ind i et 2d array af tal fra 1 til 9
		check løst korrekt med sudokuchecker
		send tallene som ikke korrekt og find et nyt random tal og indsæt i 2d array
		gæt igen og igen indtil der ikke fejl
		
		*/
		
		
		
		
		
	}
	
}