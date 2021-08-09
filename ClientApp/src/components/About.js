import React from 'react';
import WindowWrapper from "./WindowWrapper";

const Content = () => {
    return (
        <>
            <i>A collection of unsent messages to first loves.</i>
            <br/>
            <hr/>
            <span>
              <strong>Original Project: </strong>
              <a href="https://www.theunsentproject.com">theunsentproject.com</a>
          </span>
            <br/>
            <span>
              <strong>GitHub: </strong>
              <a href="https://www.github.com/brarsanmol/the-unsent-project">github.com/brarsanmol/the-unsent-project</a>
          </span>
        </>
    );
}

const About = () => {
    return <WindowWrapper
        header={<span>The Unsent Project (Windows 95 Edition)</span>}
        content={<Content/>}/>;
}

export default About;