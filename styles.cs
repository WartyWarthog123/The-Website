  /*Code for General Website*/
  * {
      box-sizing: border-box;
    }
    
    body {
      font-family: Arial, Helvetica, sans-serif;
    }
    
    header {
      background-color: #666;
      padding: 5px;
      text-align: center;
      font-size: 20px;
      color: white;
      height: 10%;
    }

    aside {
      float: left;
      width: 20%;
      padding: 20px;
      height: 80%;
      background-color: #8d8d8d;
    }
    
    article {
      float: right;
      padding: 20px;
      width: 80%;
      background-color: #acacac;
      height: 80%;
    }

    footer {
      background-color: #777;
      padding: 5px;
      text-align: center;
      color: white;
      float: right;
      width: 100%;
      height: 10%;
    }
  
  /*Code for the tab buttons*/
  body {
      font-family: Arial;
    }
  
    .tab {
      overflow: hidden;
      border: 1px solid #ccc;
      background-color: #f1f1f1;
      text-align: center;
    }
  
    .tab button {
      background-color: inherit;
      float: center;
      border: none;
      outline: none;
      cursor: pointer;
      padding: 14px 16px;
      transition: 0.3s;
      font-size: 17px;
    }
  
    .tab button:hover {
      background-color: #ddd;
    }
  
    .tab button.active {
      background-color: #ccc;
    }
  
    .tabcontent {
      display: none;
      padding: 6px 12px;
      border: 1px solid #ccc;
      border-top: none;
    }
  
    .flex-container {
      display: flex;
      flex-direction: row;
    }
  
    .flex-container > div {
      margin: 10px;
      padding: 20px;
    }
  
    /*Code for things inside the tabs*/
    .slideshow-container {
      position: relative;
      background: #f1f1f1f1;
    }
  
    .mySlides {
      display: none;
      padding: 80px;
      text-align: center;
    }
  
    .prev,
    .next {
      cursor: pointer;
      position: absolute;
      top: 50%;
      width: auto;
      margin-top: -30px;
      padding: 16px;
      color: #888;
      font-weight: bold;
      font-size: 20px;
      border-radius: 0 3px 3px 0;
      user-select: none;
    }
  
    .next {
      position: absolute;
      right: 0;
      border-radius: 3px 0 0 3px;
    }
  
    .prev:hover,
    .next:hover {
      background-color: rgba(0, 0, 0, 0.8);
      color: white;
    }
  
    .dot-container {
      text-align: center;
      padding: 20px;
      background: #ddd;
    }
  
    .dot {
      cursor: pointer;
      height: 15px;
      width: 15px;
      margin: 0 2px;
      background-color: #bbb;
      border-radius: 50%;
      display: inline-block;
      transition: background-color 0.6s ease;
    }
  
    .active,
    .dot:hover {
      background-color: #717171;
    }
  
    q {
      font-style: italic;
    }
  
    .author {
      color: cornflowerblue;
    }